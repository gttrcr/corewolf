namespace CoreWolf.Types
{
    public class Graph<VType, WType> where VType : struct where WType : class
    {
        private Matrix<VType> Matrix { get; set; }
        private Array<VType> Array { get; set; }

        public Graph()
        {
            Matrix = new();
            Array = new();
        }

        public void Add(VType vertex)
        {
            // if(Array.)
        }

        public void Add(VType vertex1, VType vertex2, WType? weight = null)
        {

        }
    }
}