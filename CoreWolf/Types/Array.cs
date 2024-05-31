namespace CoreWolf.Types
{
    public class Array<T> : Matrix<T> where T : new()
    {
        private int _cursor = 0;

        public Array() : base()
        {

        }

        public Array(int coords) : base([coords])
        {

        }

        public void Add(T val)
        {
            M.SetValue(val, _cursor++);
        }
    }
}