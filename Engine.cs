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

        private string ValidName()
        {
            string name = Obj.ValidName();
            ValidNames?.Add(name);
            return name;
        }

        public Engine Execute(string input, string? name = null)
        {
            name ??= ValidName();
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