namespace CoreWolf
{
    public class Engine
    {
        private Link Link { get; set; }
        public string Text { get; private set; }
        public List<string> DefinedFunctions { get; private set; }
        public List<string> ValidNames { get; private set; }

        public Engine(Link link)
        {
            Link = link;
            Text = "";
            DefinedFunctions = [];
            ValidNames = [];
        }

        private void ValidName(ref string? name)
        {
            Random random = new();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            name ??= new string(Enumerable.Repeat(string.Empty, 8).Select(s => chars[random.Next(0, chars.Length)]).ToArray());  //52^8 possible conbinations
            ValidNames?.Add(name);
        }

        public Engine Execute(string input, string? name = null)
        {
            ValidName(ref name);
            Text = Link.ToEngine(name + "=(" + input + ")");
            return this;
        }

        public void Define(string input)
        {
            if (!DefinedFunctions.Contains(input))
                DefinedFunctions.Add(input);
            Execute(input);
        }

        public override string ToString()
        {
            return Text;
        }
    }
}