namespace NetWolf
{
    public class WolframObj
    {
        public class WObj
        {
            public string Name;

            public WObj(string? name = "")
            {
                if (name == null)
                {
                    Random random = new Random();
                    string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                    Name = new string(Enumerable.Repeat(chars, 5).Select(s => s[random.Next(s.Length)]).ToArray());
                }
                else
                    Name = name;
            }
        }

        public class GraphObj : WObj
        {
            public List<string>? Vertices;
            public List<string>? Edges;
            public List<string>? EdgeWeight;
            public List<string>? Options;
        }
    }
}