using HtmlAgilityPack;
using System.Net;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace NetWolf.Scratcher
{
    public static class Scratcher
    {
        private static readonly string buildinSymbolsJsonFile = "BuiltinSymbols.json";
        private static readonly string buildinSymbolsBaseFolder = "BuiltinSymbols";
        private static readonly string extendedSymbolsBaseFolder = "ExtendedSymbols";

        private static string? GetHTMLCode(string url, int attempt = 10)
        {
            if (attempt == 0)
                return null;

            try
            {
                HttpClient client = new HttpClient();
                using (HttpResponseMessage response = client.GetAsync(url).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        return content.ReadAsStringAsync().Result;
                    }
                }
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

        public struct Prototype
        {
            public string Signature;
            public string Comment;
            public List<string> ArgsType;
        }

        public struct Command
        {
            public string Name;
            public string Url;
            public List<Prototype> Prototypes;
            public Type Type;

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
            Regex regex = new Regex(@"(?![^)(]*\([^)(]*?\)\)),(?![^\[]*\])(?![^\{]*\})(?![^\(]*\))");
            string argsScope = signature.Replace(name, "");
            if (argsScope != "")
                argsScope = argsScope.Substring(1, argsScope.Length - 1);
            if (argsScope != "")
                argsScope = argsScope.Substring(0, argsScope.Length - 1);
            List<string> splits = regex.Split(argsScope).ToList().Where(x => x != "").ToList();

            List<string> argsType = new List<string>();
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

            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = new HtmlDocument();
            string? htmlMainPage = GetHTMLCode(baseUrl + "/language/guide/AlphabeticalListing");
            if (htmlMainPage == null)
                return;

            doc.LoadHtml(htmlMainPage);
            List<HtmlNode> nodes = doc.DocumentNode.SelectNodes("//span[@class='IFSans']").ToList();
            int downloaded = 0;
            List<Command> commands = new List<Command>();
            Parallel.ForEach(nodes, node =>
            {
                //get name
                Command c = new Command();
                c.Name = WebUtility.HtmlDecode(node.InnerText);

                //get url
                HtmlDocument d = new HtmlDocument();
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

                downloaded++;
                Console.WriteLine((int)((double)downloaded * 100.0 / (double)nodes.Count));

                commands.Add(c);
            });

            commands = commands.OrderBy(x => x.Name).ToList();
            File.WriteAllText(buildinSymbolsJsonFile, JsonConvert.SerializeObject(commands));
        }

        private static void CreateSymbols()
        {
            List<Command>? commands = JsonConvert.DeserializeObject<List<Command>>(File.ReadAllText(buildinSymbolsJsonFile));
            if (commands == null)
                return;

            const string buildinSymbolFunctionStructure = @"//TAB_HERE///<summary>
//TAB_HERE/////COMMENT_HERE
//TAB_HERE/////URL_HERE
//TAB_HERE///</summary>
//TAB_HEREpublic static Engine //NAME_HERE(this Engine en, //ARGUMENTS_OBJECT_HERE, string? name = null)
//TAB_HERE{
//TAB_HERE//TAB_HEREreturn en.Execute(""//NAME_HERE[//ARGUMENTS_HERE]"", name);
//TAB_HERE}

";

            const string extendedSymbolFunctionStructure = @"//TAB_HERE///<summary>
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
                List<string> extendedOverloadCheck = new List<string>();
                string buildinSymbolsSourceCode = "";
                string extendedSymbolsSourceCode = "";
                List<Command> functionCommands = commands.Where(x => x.Name.StartsWith(ch) && x.Type == Type.Function).ToList();
                for (int i = 0; i < functionCommands.Count; i++)
                {
                    Command c = functionCommands[i];
                    List<Prototype> prototypes = c.Prototypes.GroupBy(x => string.Join("", x.ArgsType)).Select(x => x.FirstOrDefault()).ToList();
                    for (int p = 0; p < prototypes.Count; p++)
                    {
                        Prototype proto = prototypes[p];
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

                        buildinSymbolsSourceCode += buildinSymbolFunctionStructure
                        .Replace("//TAB_HERE", "\t\t")
                        .Replace("//COMMENT_HERE", proto.Comment)
                        .Replace("//URL_HERE", functionCommands[i].Url)
                        .Replace("//NAME_HERE", functionCommands[i].Name)
                        .Replace("//ARGUMENTS_OBJECT_HERE, ", argumentsObject.Replace("object", "string"))
                        .Replace("//ARGUMENTS_HERE", argument);

                        if (proto.ArgsType.Count == 1 && !extendedOverloadCheck.Contains(c.Name))
                        {
                            extendedOverloadCheck.Add(c.Name);
                            extendedSymbolsSourceCode += extendedSymbolFunctionStructure
                            .Replace("//TAB_HERE", "\t\t")
                            .Replace("//COMMENT_HERE", proto.Comment)
                            .Replace("//URL_HERE", functionCommands[i].Url)
                            .Replace("//NAME_HERE", functionCommands[i].Name);
                        }
                    }
                }

                buildinSymbolsSourceCode = @"namespace NetWolf
{
    public static class BuiltinSymbol//CHAR_HERE
    {
//SOURCE_CODE_HERE
    }
}".Replace("//CHAR_HERE", ch.ToString()).Replace("//SOURCE_CODE_HERE", buildinSymbolsSourceCode);
                File.WriteAllText(buildinSymbolsBaseFolder + "/BuiltinSymbols" + ch + ".cs", buildinSymbolsSourceCode);

                extendedSymbolsSourceCode = @"namespace NetWolf
{
    public static class ExtendedSymbols//CHAR_HERE
    {
//SOURCE_CODE_HERE
    }
}".Replace("//CHAR_HERE", ch.ToString()).Replace("//SOURCE_CODE_HERE", extendedSymbolsSourceCode);
                File.WriteAllText(extendedSymbolsBaseFolder + "/ExtendedSymbols" + ch + ".cs", extendedSymbolsSourceCode);
            }

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C dotnet format";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }

        public static void Main()
        {
            if (!File.Exists(buildinSymbolsJsonFile))
                CreateJsonFile();

            if (Directory.Exists(buildinSymbolsBaseFolder))
                Directory.Delete(buildinSymbolsBaseFolder, true);
            if (Directory.Exists(extendedSymbolsBaseFolder))
                Directory.Delete(extendedSymbolsBaseFolder, true);

            Directory.CreateDirectory(buildinSymbolsBaseFolder);
            Directory.CreateDirectory(extendedSymbolsBaseFolder);

            CreateSymbols();
        }
    }
}