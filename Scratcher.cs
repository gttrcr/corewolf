using HtmlAgilityPack;
using System.Net;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace NetWolf.Scratcher
{
    public static class Scratcher
    {
        private static readonly string baseFolder = "BuiltinSymbols";

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
            File.WriteAllText(baseFolder + "/BuiltinSymbols.json", JsonConvert.SerializeObject(commands));
        }

        private static void CreateFromJsonFile()
        {
            List<Command>? commands = JsonConvert.DeserializeObject<List<Command>>(File.ReadAllText(baseFolder + "/BuiltinSymbols.json"));
            if (commands == null)
                return;

            const string functionStructure = @"//TAB_HERE///<summary>
//TAB_HERE/////COMMENT_HERE
//TAB_HERE/////URL_HERE
//TAB_HERE///</summary>
//TAB_HEREpublic static Engine //NAME_HERE(this Engine en, //ARGUMENTS_OBJECT_HERE, string? name = null)
//TAB_HERE{
//TAB_HERE//TAB_HEREreturn en.Execute(""//NAME_HERE[//ARGUMENTS_HERE]"", name);
//TAB_HERE}

";

            //            const string overloadFunctionStructure = @"//TAB_HERE///<summary>
            ////TAB_HERE/////COMMENT_HERE
            ////TAB_HERE/////URL_HERE
            ////TAB_HERE///</summary>
            ////TAB_HEREpublic static Engine //NAME_HERE(this Engine en, string? name = null)
            ////TAB_HERE{
            ////TAB_HERE    return en.Execute(""//NAME_HERE["" + en.ValidNames.Last() + ""]"", name);
            ////TAB_HERE}
            //
            //";

            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                string sourceCode = "";
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
                        string argument = string.Join(" + \", \" + ", proto.ArgsType.Select(x => x.Split(' ').Last()));
                        if (argument != "")
                            argument = "\" + " + argument + " + \"";

                        sourceCode += functionStructure
                        .Replace("//TAB_HERE", "\t\t")
                        .Replace("//COMMENT_HERE", proto.Comment)
                        .Replace("//URL_HERE", functionCommands[i].Url)
                        .Replace("//NAME_HERE", functionCommands[i].Name)
                        .Replace("//ARGUMENTS_OBJECT_HERE, ", argumentsObject)
                        .Replace("//ARGUMENTS_HERE", argument);
                    }
                }

                sourceCode = @"namespace NetWolf
{
    public static class BuiltinSymbol//CHAR_HERE
    {
//SOURCE_CODE_HERE
    }
}".Replace("//CHAR_HERE", ch.ToString()).Replace("//SOURCE_CODE_HERE", sourceCode);
                File.WriteAllText(baseFolder + "/BuiltinSymbols" + ch + ".cs", sourceCode);
            }
        }

        public static void Start()
        {
            if (!Directory.Exists(baseFolder))
            {
                Directory.CreateDirectory(baseFolder);
                CreateJsonFile();
            }
            else if (!File.Exists(baseFolder + "/BuiltinSymbols.json"))
                CreateJsonFile();

            CreateFromJsonFile();
        }
    }
}