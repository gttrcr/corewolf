using CoreWolf;
using CoreWolf.Types;

namespace Test
{
    public class Program
    {
        public static void Main()
        {
            Link link = new();
            Engine en = link.Engine;

            Matrix<int> matrix = new(7, 7);
            Matrix<int> into = new(7);
            into.Set(1, 1);
            into.Set(1, 2);
            into.Set(1, 3);
            into.Set(1, 4);
            matrix.Set(into, 1);

            into = new(7);
            into.Set(1, 2);
            into.Set(1, 3);
            into.Set(1, 5);
            into.Set(1, 6);
            matrix.Set(into, 2);

            into = new(7);
            into.Set(1, 3);
            into.Set(1, 4);
            into.Set(1, 6);
            into.Set(1, 7);
            matrix.Set(into, 3);

            into = new(7);
            into.Set(1, 1);
            into.Set(1, 4);
            into.Set(1, 5);
            into.Set(1, 6);
            matrix.Set(into, 4);

            int max = 7;
            for (int i1 = 0; i1 < Math.Pow(2, max); i1++)
            {
                int[] bitString1 = [.. Convert.ToString(i1, 2).PadLeft(max, '0').ToArray().Select(x => x == '0' ? 0 : 1)];
                Matrix<int> into1 = new(max);
                for (int j = 0; j < bitString1.Length; j++)
                    into1.Set(bitString1[j], j + 1);
                matrix.Set(into1, 5);

                for (int i2 = 0; i2 < Math.Pow(2, max); i2++)
                {
                    int[] bitString2 = [.. Convert.ToString(i2, 2).PadLeft(max, '0').ToArray().Select(x => x == '0' ? 0 : 1)];
                    Matrix<int> into2 = new(max);
                    for (int j = 0; j < bitString2.Length; j++)
                        into2.Set(bitString2[j], j + 1);
                    matrix.Set(into2, 6);

                    for (int i3 = 0; i3 < Math.Pow(2, max); i3++)
                    {
                        int[] bitString3 = [.. Convert.ToString(i3, 2).PadLeft(max, '0').ToArray().Select(x => x == '0' ? 0 : 1)];
                        Matrix<int> into3 = new(max);
                        for (int j = 0; j < bitString3.Length; j++)
                            into3.Set(bitString3[j], j + 1);
                        matrix.Set(into3, 7);

                        string res = en.Det(matrix).Text;

                        if (!res.Equals("0"))
                            Console.WriteLine(into1 + "#" + into2 + "#" + into3);
                    }
                }
            }
        }
    }
}