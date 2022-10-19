namespace NetWolf
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
            DefinedFunctions = new List<string>();
            ValidNames = new List<string>();
        }

        private void ValidName(ref string? name)
        {
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            name ??= new string(Enumerable.Repeat(chars, 6).Select(s => s[random.Next(s.Length)]).ToArray());
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
    }
}