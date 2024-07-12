using System.Text;
using Newtonsoft.Json;

namespace CoreWolf
{
    public class Engine
    {
        private Link Link { get; set; }

        public T Result<T>()
        {
            return (T)Convert.ChangeType(ParseResponse(), typeof(T));
        }

        public string Result()
        {
            return Result<string>();
        }

        public List<string> DefinedFunctions { get; private set; }
        public List<string> ValidNames { get; private set; }

        public Engine()
        {
            Link = new();
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
            Link.ToSocket(name + "=(" + input + ")");
            return this;
        }

        private string ParseResponse()
        {
            string response = Encoding.ASCII.GetString(Link.Buffer, 0, Link.Buffer.Length);
            Result res = JsonConvert.DeserializeObject<Result>(response);
            if (!res.IsOk())
                throw new Exception("Result " + res);

            return res.Data;
        }

        public void Define(string input)
        {
            if (!DefinedFunctions.Contains(input))
                DefinedFunctions.Add(input);
            Execute(input);
        }

        public override string ToString()
        {
            return Result<string>();
        }

        public void Dispose()
        {
            this.CloseKernels(string.Empty, null);
            Link.Dispose();
        }
    }
}