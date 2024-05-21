using Newtonsoft.Json;

namespace CoreWolf
{
    public struct Result
    {
        public int Error;
        public string Data;

        public readonly bool IsOk()
        {
            return Error >= 0;
        }

        public override readonly string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}