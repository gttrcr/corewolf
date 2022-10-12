namespace NetWolf
{
    public static class ExtendedBuiltinSymbolsG
    {
        ///<summary>
        ///yields a graph from the given object
        ///</summary>
        public static Engine Graph(this Engine en, GraphObj graphObj, string? name = null)
        {
            return en.Execute("Graph[" + graphObj + "]", name);
        }
    }

    public class GraphObj : WLObj
    {
        public List<string> Edges { get; set; }
        public List<string> Vertex { get; set; }
        public List<string> EdgeWeight { get; set; }
        public string VertexLabels { get; set; }

        public GraphObj()
        {
            Edges = new List<string>();
            Vertex = new List<string>();
            EdgeWeight = new List<string>();
            VertexLabels = "";
        }

        public override string ToString()
        {
            List<string> parts = new List<string>();
            parts.Add(Edges.Count > 0 ? "{" + string.Join(',', Edges) + "}" : "");
            parts.Add(Vertex.Count > 0 ? "{" + string.Join(',', Vertex) + "}" : "");
            parts.Add(EdgeWeight.Count > 0 ? "EdgeWeight -> {" + string.Join(',', EdgeWeight) + "}" : "");
            parts.Add(!string.IsNullOrEmpty(VertexLabels) ? "VertexLabels->\"" + VertexLabels + "\"" : "");
            parts = parts.Where(x => !string.IsNullOrEmpty(x)).ToList();

            return string.Join(',', parts);
        }
    }
}