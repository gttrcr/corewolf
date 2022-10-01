namespace NetWolf
{
    public static class Ext
    {
        //public static List<Engine> ToList(this Engine res)
        //{
        //    List<Engine> ret = new();
        //    int Y = Convert.ToInt32(res.Length(new Engine(res.Link, res.Text)).Text);
        //    for (int y = 1; y <= Y; y++)
        //        ret.Add(res.Part(new Engine(res.Link, res.Text), y));
        //
        //    return ret;
        //}
        //
        //public static List<List<Engine>> ToMatrix(this Engine res)
        //{
        //    List<List<Engine>> ret = new();
        //    List<Engine> arr = ToList(res);
        //    for (int i = 0; i < arr.Count; i++)
        //        ret.Add(ToList(new Engine(res.Link, arr[i].Text)));
        //
        //    return ret;
        //}
    }

    public class Engine
    {
        private Link Link { get; set; }
        private string Text { get; set; }
        public List<string> DefinedFunctions { get; private set; }
        public List<string> ValidNames { get; private set; }

        public Engine(Link link)
        {
            Link = link;
            Text = "";
            DefinedFunctions = new List<string>();
            ValidNames = new List<string>();
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

        public bool IsBooleanTrue()
        {
            return Text == "True";
        }

        public bool IsBooleanFalse()
        {
            return Text == "False";
        }

        //public Type Type()
        //{
        //    if (NumberQ().IsBooleanTrue())
        //        return NetWolf.Type.Number;
        //
        //    if (ArrayQ().IsBooleanTrue())
        //        return NetWolf.Type.Array;
        //
        //    if (MatrixQ().IsBooleanTrue())
        //        return NetWolf.Type.Matrix;
        //
        //    if (PolynomialQ().IsBooleanTrue())
        //        return NetWolf.Type.Polynomial;
        //
        //    return NetWolf.Type.Unknow;
        //}

        private string ValidName()
        {
            string name = Obj.ValidName();
            ValidNames?.Add(name);
            return name;
        }

        public Engine Simplify(string input, string? name = null)
        {
            name ??= ValidName();
            string toEngine = name + "=Simplify[" + input + "]";
            return Execute(toEngine);
        }

        public Engine Simplify(string? name = null)
        {
            return Simplify(ValidNames.Last(), name);
        }

        public Engine Length(string input, string? name = null)
        {
            name ??= Obj.ValidName();
            string inputStr = name + "=Length[" + input + "]";
            return Execute(inputStr);
        }

        public Engine Length(string? name = null)
        {
            return Length(ValidNames.Last(), name);
        }

        public Engine Part(string input, int index = 1, string? name = null)
        {
            name ??= Obj.ValidName();
            string inputStr = name + "=" + input + "[[" + index + "]]";
            return Execute(inputStr);
        }

        public Engine Part(int index = 1, string? name = null)
        {
            return Part(ValidNames.Last(), index, name);
        }

        //public Engine NumberQ(Engine? input = null, string? name = null)
        //{
        //    input ??= new Engine(ValidNames.Last());
        //    string inputStr = name + "=NumberQ[" + input.Text + "]";
        //    return Execute(inputStr);
        //}
        //
        //public Engine NumberQ(string input, string? name = null)
        //{
        //    Engine? tr;
        //    FromStringToTransferable(input, out name, out tr);
        //    return NumberQ(tr, name);
        //}
        //
        //public Engine NumberQ()
        //{
        //    return NumberQ(Text);
        //}
        //
        //public Engine ArrayQ(Engine? input = null, string? name = null)
        //{
        //    input ??= new Engine(ValidNames.Last());
        //    string inputStr = name + "=ArrayQ[" + input.Text + "]";
        //    return Execute(inputStr);
        //}
        //
        //public Engine MatrixQ(Engine? input = null, string? name = null)
        //{
        //    input ??= new Engine(ValidNames.Last());
        //    string inputStr = name + "=MatrixQ[" + input.Text + "]";
        //    return Execute(inputStr);
        //}
        //
        //public Engine PolynomialQ(Engine? input = null, string? name = null)
        //{
        //    input ??= new Engine(ValidNames.Last());
        //    string inputStr = name + "=PolynomialQ[" + input.Text + "]";
        //    return Execute(inputStr);
        //}
        //
        //public Engine Abs(Engine? input = null, string? name = null)
        //{
        //    input ??= new Engine(ValidNames.Last());
        //    string inputStr = name + "=Abs[" + input.Text + "]";
        //    return Execute(inputStr);
        //}
        //
        //public Engine Flatten(Engine? input = null, int index = 0, string? name = null)
        //{
        //    input ??= new Engine(ValidNames.Last());
        //    string inputStr = name + "=Flatten[" + input + ", " + index + "]";
        //    return Execute(inputStr);
        //}
        //
        //public Engine Flatten(string input = "%", int index = 0, string? name = null)
        //{
        //    string inputStr = name + "=Flatten[" + input + ", " + index + "]";
        //    return Execute(inputStr);
        //}
        //
        //public Engine Export(string path, string obj = "%", string? name = null)
        //{
        //    string inputStr = name + "=Export[\"" + path + "\", " + obj + "]";
        //    return Execute(inputStr);
        //}
        //
        //public Engine Graph(Obj.GraphObj gr)
        //{
        //    string vertices = "";
        //    if (gr.Vertices != null)
        //        vertices = string.Join(',', gr.Vertices);
        //
        //    string edges = "";
        //    if (gr.Edges != null)
        //        edges = string.Join(',', gr.Edges);
        //
        //    string edgeWeight = "";
        //    if (gr.EdgeWeight != null)
        //        edgeWeight = string.Join(',', gr.EdgeWeight);
        //
        //    string options = "";
        //    if (gr.Options != null)
        //        options = string.Join(',', gr.Options);
        //
        //    string inputStr = gr.Name + "=Graph[{" + vertices + "}" + (edges == "" ? edges : ", {" + edges + "}") + (options == "" ? options : ", " + options) + "]";
        //    return Execute(inputStr);
        //}
    }
}