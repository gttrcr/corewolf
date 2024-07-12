namespace CoreWolf.Types
{
    public class Matrix<T> where T : new()
    {
        protected T[] M { get; set; }
        private int[] Dimensions { get; set; }

        public Matrix()
        {
            M = [];
            Dimensions = [];
        }

        public Matrix(params int[] coords)
        {
            M = new T[Product(coords)];
            Array.Fill(M, new T());
            Dimensions = coords;
        }

        private static int Position(int[] coords, int[] dimensions)
        {
            if (dimensions == null)
                throw new NullReferenceException("null Dimensions");

            if (coords.Length == 1)
                return coords[0];

            coords = [.. coords.ToList().GetRange(0, coords.Length - 2), coords[0] * dimensions[1] + coords[1]];
            dimensions = [.. dimensions.ToList().GetRange(2, coords.Length - 1), dimensions[0] * dimensions[1]];

            if (coords.Length > 1)
                return Matrix<T>.Position(coords, dimensions);

            return coords[0];
        }

        private static int Product(int[] coords)
        {
            int product = 1;
            coords.ToList().ForEach(x => product *= x);

            return product;
        }

        public void Set(T val, params int[] coords)
        {
            coords = [.. coords.Select(x => x - 1)];
            M[Matrix<T>.Position(coords, Dimensions)] = val;
        }

        public void Set(Matrix<T> vals, params int[] coords)
        {
            coords = [.. coords.Select(x => x - 1)];
            int[] counter = new int[Dimensions.Length];
            do
            {
                if (counter.ToList().GetRange(0, coords.Length).SequenceEqual(coords))
                    M[Matrix<T>.Position(counter, Dimensions)] = vals.Get([.. counter.ToList().GetRange(coords.Length, counter.Length - coords.Length).Select(x => x + 1)]);
            } while (CountInBase(ref counter, Dimensions));
        }

        public T Get(params int[] coords)
        {
            coords = [.. coords.Select(x => x - 1)];
            return M[Matrix<T>.Position(coords, Dimensions)];
        }

        private static bool CountInBase(ref int[] counter, int[] @base, int position = 0)
        {
            if (position == counter.Length)
                return false;

            if (counter[position] == @base[position] - 1)
            {
                counter[position] = 0;
                return CountInBase(ref counter, @base, position + 1);
            }
            else
                counter[position]++;

            return true;
        }

        private static string Chunk(string[] cs, int[] @base, int position = 0)
        {
            if (cs.Length == 1)
                return cs[0];

            return Chunk(Extension.ToString(cs.Chunk(@base[position]).ToArray()), @base, position + 1);
        }

        public override string ToString()
        {
            return Chunk(M.Select(x => (x?.ToString()) ?? string.Empty).ToArray(), Dimensions);
        }
    }
}