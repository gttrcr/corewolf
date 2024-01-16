using HtmlAgilityPack;
using System.Net;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Scraper
{
    public class Program
    {
        private static readonly string builtinSymbolsJsonFile = "BuiltinSymbols.json";
        private static readonly string builtinFunctionsBaseFolder = "../CoreWolf/BuiltinFunctions";
        private static readonly string extendedFunctionsBaseFolder = "../CoreWolf/ExtendedFunctions";

        private static string? GetHTMLCode(string url, int attempt = 10)
        {
            if (attempt == 0)
                return null;

            try
            {
                HttpClient client = new();
                using HttpResponseMessage response = client.GetAsync(url).Result;
                using HttpContent content = response.Content;
                return content.ReadAsStringAsync().Result;
            }
            catch
            {
                return GetHTMLCode(url, --attempt);
            }
        }

        public enum Type
        {
            None,
            Function,
            Other
        }

        public class Prototype
        {
            public string Signature { get; set; }
            public string Comment { get; set; }
            public List<string> ArgsType { get; set; }

            public Prototype()
            {
                Signature = string.Empty;
                Comment = string.Empty;
                ArgsType = new();
            }
        }

        public class Command
        {
            public string Name { get; set; }
            public string Url { get; set; }
            public List<Prototype> Prototypes { get; set; }
            public Type Type { get; set; }

            public Command()
            {
                Name = "";
                Url = "";
                Prototypes = new List<Prototype>();
                Type = Type.None;
            }
        }

        private static List<string> GetArgsType(string signature, string name)
        {
            Regex regex = new(@"(?![^)(]*\([^)(]*?\)\)),(?![^\[]*\])(?![^\{]*\})(?![^\(]*\))");
            string argsScope = signature.Replace(name, "");
            if (argsScope != "")
                argsScope = argsScope.Substring(1, argsScope.Length - 1);
            if (argsScope != "")
                argsScope = argsScope.Substring(0, argsScope.Length - 1);
            List<string> splits = regex.Split(argsScope).ToList().Where(x => x != "").ToList();

            List<string> argsType = new();
            for (int s = 0; s < splits.Count; s++)
            {
                if (splits[s].StartsWith('{') && splits[s].EndsWith('}'))
                    argsType.Add("List<object> arg" + s.ToString());
                else
                    argsType.Add("object arg" + s.ToString());
            }

            return argsType;
        }

        private static Type GetCommandType(string signature, string name)
        {
            //get type
            string[] components = signature.Split(name);
            if (components.Length == 2)
            {
                string args = components[1];
                if (args.StartsWith("[") && args.EndsWith("]"))
                    return Type.Function;
            }

            return Type.Other;
        }

        private static void CreateJsonFile()
        {
            const string baseUrl = "https://reference.wolfram.com";

            HtmlWeb web = new();
            HtmlDocument doc = new();
            string? htmlMainPage = GetHTMLCode(baseUrl + "/language/guide/AlphabeticalListing");
            if (htmlMainPage == null)
                return;

            doc.LoadHtml(htmlMainPage);
            List<HtmlNode> nodes = doc.DocumentNode.SelectNodes("//span[@class='IFSans']").ToList();
            int downloaded = 0;
            List<Command> commands = new();
            nodes = nodes.GetRange(0, 10);
            Parallel.ForEach(nodes, new ParallelOptions() { MaxDegreeOfParallelism = 4 }, node =>
            {
                //get name
                Command c = new()
                {
                    Name = WebUtility.HtmlDecode(node.InnerText)
                };

                //get url
                HtmlDocument d = new();
                d.LoadHtml(node.InnerHtml);
                c.Url = baseUrl + d.DocumentNode.SelectSingleNode("//a").Attributes["href"].Value;

                //get comment
                string? commandPage = GetHTMLCode(c.Url);
                if (commandPage == null)
                {
                    commands.Add(c);
                    return;
                }

                d.LoadHtml(commandPage);
                List<HtmlNode> functionIntros = d.DocumentNode.SelectNodes("//div[@class='functionIntro']").ToList();
                c.Prototypes = functionIntros.Select(x => new Prototype()
                {
                    Signature = WebUtility.HtmlDecode(x.ChildNodes[1].InnerText).Trim(),
                    Comment = WebUtility.HtmlDecode(x.ChildNodes[3].InnerText).Trim(),
                    ArgsType = GetArgsType(WebUtility.HtmlDecode(x.ChildNodes[1].InnerText).Trim(), c.Name)
                }).ToList();

                //get type
                c.Type = GetCommandType(c.Prototypes[0].Signature, c.Name);

                Console.WriteLine(downloaded++ * 100.0 / nodes.Count);
                commands.Add(c);
            });

            commands = commands.OrderBy(x => x.Name).ToList();
            File.WriteAllText(builtinSymbolsJsonFile, JsonSerializer.Serialize(commands));
        }

        private static void CreateBuiltinFunctions()
        {
            List<Command>? commands = JsonSerializer.Deserialize<List<Command>>(File.ReadAllText(builtinSymbolsJsonFile));
            if (commands == null)
                return;

            const string builtinFunctionStructure = @"//TAB_HERE///<summary>
//TAB_HERE/////COMMENT_HERE
//TAB_HERE/////URL_HERE
//TAB_HERE///</summary>
//TAB_HEREpublic static Engine //NAME_HERE(this Engine en, //ARGUMENTS_OBJECT_HERE, string? name = null)
//TAB_HERE{
//TAB_HERE//TAB_HEREreturn en.Execute(""//NAME_HERE[//ARGUMENTS_HERE]"", name);
//TAB_HERE}

";

            const string extendedFunctionStructure = @"//TAB_HERE///<summary>
//TAB_HERE/////COMMENT_HERE
//TAB_HERE/////URL_HERE
//TAB_HERE///</summary>
//TAB_HEREpublic static Engine //NAME_HERE(this Engine en, string? name = null)
//TAB_HERE{
//TAB_HERE//TAB_HEREreturn en.Execute(""//NAME_HERE["" + en.ValidNames.Last() + ""]"", name);
//TAB_HERE}

";

            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                List<string> extendedOverloadCheck = new();
                string builtinFunctionsSourceCode = "";
                string extendedFunctionsSourceCode = "";
                List<Command> functionCommands = commands.Where(x => x.Name.StartsWith(ch) && x.Type == Type.Function).ToList();
                for (int i = 0; i < functionCommands.Count; i++)
                {
                    Command c = functionCommands[i];
                    List<Prototype?> prototypes = c.Prototypes.GroupBy(x => string.Join("", x.ArgsType)).Select(x => x.FirstOrDefault()).ToList();
                    for (int p = 0; p < prototypes.Count; p++)
                    {
                        Prototype? proto = prototypes[p];
                        if (proto == null)
                            continue;

                        string argumentsObject = string.Join(", ", proto.ArgsType);
                        if (argumentsObject != "")
                            argumentsObject += ", ";
                        string argument = string.Join(" + \", \" + ", proto.ArgsType.Select(x =>
                        {
                            string body = x.Split(' ').Last();
                            if (x.StartsWith("List"))
                                return "\"{\" + string.Join(',', " + body + ") + \"}\"";
                            return body;
                        }));
                        if (argument != "")
                            argument = "\" + " + argument + " + \"";

                        builtinFunctionsSourceCode += builtinFunctionStructure
                        .Replace("//TAB_HERE", "\t\t")
                        .Replace("//COMMENT_HERE", proto.Comment)
                        .Replace("//URL_HERE", functionCommands[i].Url)
                        .Replace("//NAME_HERE", functionCommands[i].Name)
                        .Replace("//ARGUMENTS_OBJECT_HERE, ", argumentsObject) //.Replace("object", "string"))
                        .Replace("//ARGUMENTS_HERE", argument);

                        if (proto.ArgsType.Count == 1 && !extendedOverloadCheck.Contains(c.Name))
                        {
                            extendedOverloadCheck.Add(c.Name);
                            extendedFunctionsSourceCode += extendedFunctionStructure
                            .Replace("//TAB_HERE", "\t\t")
                            .Replace("//COMMENT_HERE", proto.Comment)
                            .Replace("//URL_HERE", functionCommands[i].Url)
                            .Replace("//NAME_HERE", functionCommands[i].Name);
                        }
                    }
                }

                builtinFunctionsSourceCode = @"using System.Collections.Generic;

namespace CoreWolf
{
    public static class BuiltinFunction//CHAR_HERE
    {
//SOURCE_CODE_HERE
    }
}".Replace("//CHAR_HERE", ch.ToString()).Replace("//SOURCE_CODE_HERE", builtinFunctionsSourceCode);
                File.WriteAllText(builtinFunctionsBaseFolder + "/BuiltinFunctions" + ch + ".cs", builtinFunctionsSourceCode);

                extendedFunctionsSourceCode = @"namespace CoreWolf
{
    public static class ExtendedFunctions//CHAR_HERE
    {
//SOURCE_CODE_HERE
    }
}".Replace("//CHAR_HERE", ch.ToString()).Replace("//SOURCE_CODE_HERE", extendedFunctionsSourceCode);
                File.WriteAllText(extendedFunctionsBaseFolder + "/ExtendedFunctions" + ch + ".cs", extendedFunctionsSourceCode);
            }

            GttrcrGist.Process.Run(null, "dotnet format ../CoreWolf");
        }

        public static void Main()
        {
            if (!File.Exists(builtinSymbolsJsonFile))
                CreateJsonFile();

            if (Directory.Exists(builtinFunctionsBaseFolder))
                Directory.Delete(builtinFunctionsBaseFolder, true);
            if (Directory.Exists(extendedFunctionsBaseFolder))
                Directory.Delete(extendedFunctionsBaseFolder, true);

            Directory.CreateDirectory(builtinFunctionsBaseFolder);
            Directory.CreateDirectory(extendedFunctionsBaseFolder);

            CreateBuiltinFunctions();
        }
    }
}