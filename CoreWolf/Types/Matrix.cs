namespace CoreWolf.Types
{
    public class Matrix<T> where T : new()
    {
        protected T[] M { get; set; }
        private int[]? Dimensions { get; set; }

        public Matrix()
        {
            M = [];
            Dimensions = null;
        }

        public Matrix(params int[] coords)
        {
            M = new T[Product(coords)];
            Array.Fill(M, new T());
            Dimensions = coords;
        }

        private int Position(int[] coords, int[]? dimensions = null)
        {
            if (dimensions == null)
            {
                if (Dimensions == null)
                    throw new NullReferenceException("null Dimensions");

                if (Dimensions != null)
                    dimensions = Dimensions;
            }

            coords = [.. coords.ToList().GetRange(0, coords.Length - 2), (coords[0] - 1) * dimensions[1] + coords[1]];
            dimensions = [.. dimensions.ToList().GetRange(2, coords.Length - 1), dimensions[0] * dimensions[1]];

            if (coords.Length > 1)
                return Position(coords, dimensions);

            return coords[0] - 1;
        }

        private static int Product(int[] coords)
        {
            int product = 1;
            coords.ToList().ForEach(x => product *= x);

            return product;
        }

        public void Set(T val, params int[] coords)
        {
            M[Position(coords)] = val;
        }

        public T Get(params int[] coords)
        {
            return M[Position(coords)];
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

        // public T[] Flatten()
        // {
        //     T[] fl = new T[M.LongLength];
        //     int[] @base = Enumerable.Range(0, M.Rank).ToList().Select(x => M.GetUpperBound(x) + 1).ToArray();
        //     int[] coords = new int[@base.Length];
        //     int i = 0;
        //     do
        //     {
        //         fl[i++] = (T)M.GetValue(coords);
        //     }
        //     while (Matrix<T>.CountWithLimits(ref coords, @base));

        //     return fl;
        // }

        public override string ToString()
        {
            // int[] @base = Enumerable.Range(0, M.Rank).ToList().Select(x => M.GetUpperBound(x) + 1).ToArray();
            // return Chunk(Flatten().Select(x => (x?.ToString()) ?? string.Empty).ToArray(), @base);
            return Chunk(M.Select(x => (x?.ToString()) ?? string.Empty).ToArray(), Dimensions);
        }
    }
}