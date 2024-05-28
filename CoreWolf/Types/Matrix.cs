namespace CoreWolf.Types
{
    public class Matrix<T> where T : notnull
    {
        protected Array _m { get; set; }

        public Matrix()
        {
            _m = Array.Empty<T>();
        }

        public Matrix(params int[] coords)
        {
            _m = Array.CreateInstance(typeof(T), coords);
        }

        public void Set(T val, params int[] coords)
        {
            _m.SetValue(val, coords.Select(x => x - 1).ToArray());
        }

        public T Get(params int[] coords)
        {
            return (T)_m.GetValue(coords.Select(x => x - 1).ToArray());
        }

        private static bool CountWithLimits(ref int[] coords, int[] @base, int position = 0)
        {
            if (position == coords.Length)
                return false;

            if (coords[position] == @base[position] - 1)
            {
                coords[position] = 0;
                return CountWithLimits(ref coords, @base, position + 1);
            }
            else
                coords[position]++;

            return true;
        }

        private static string Chunk(string[] cs, int[] @base, int position = 0)
        {
            if (cs.Length == 1)
                return cs[0];

            return Chunk(Extension.ToString(cs.Chunk(@base[position]).ToArray()), @base, position + 1);
        }

        public T[] Flatten()
        {
            T[] fl = new T[_m.LongLength];
            int[] @base = Enumerable.Range(0, _m.Rank).ToList().Select(x => _m.GetUpperBound(x) + 1).ToArray();
            int[] coords = new int[@base.Length];
            int i = 0;
            do
            {
                fl[i++] = (T)_m.GetValue(coords);
            }
            while (Matrix<T>.CountWithLimits(ref coords, @base));

            return fl;
        }

        public override string ToString()
        {
            int[] @base = Enumerable.Range(0, _m.Rank).ToList().Select(x => _m.GetUpperBound(x) + 1).ToArray();
            return Chunk(Flatten().Select(x => (x?.ToString()) ?? string.Empty).ToArray(), @base);
        }
    }
}