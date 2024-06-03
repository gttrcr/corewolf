using CoreWolf;
using CoreWolf.Types;

namespace Test
{
    public class Program
    {
        private static void Seven_x_seven()
        {
            Engine en = new();

            Matrix<ZeroString> matrix = new(7, 7);
            Matrix<ZeroString> into = new(7);
            into.Set("1", 1);
            into.Set("1", 2);
            into.Set("1", 3);
            into.Set("1", 4);
            matrix.Set(into, 1);

            into = new(7);
            into.Set("1", 2);
            into.Set("1", 4);
            into.Set("1", 5);
            into.Set("1", 6);
            matrix.Set(into, 2);

            into = new(7);
            into.Set("1", 3);
            into.Set("1", 4);
            into.Set("1", 6);
            into.Set("1", 7);
            matrix.Set(into, 3);

            into = new(7);
            into.Set("1", 1);
            into.Set("1", 3);
            into.Set("1", 5);
            into.Set("1", 6);
            matrix.Set(into, 4);

            into = new(7);
            into.Set("a1", 1);
            into.Set("b1", 2);
            into.Set("c1", 3);
            into.Set("d1", 4);
            into.Set("e1", 5);
            into.Set("f1", 6);
            into.Set("g1", 7);
            matrix.Set(into, 5);

            into = new(7);
            into.Set("a2", 1);
            into.Set("b2", 2);
            into.Set("c2", 3);
            into.Set("d2", 4);
            into.Set("e2", 5);
            into.Set("f2", 6);
            into.Set("g2", 7);
            matrix.Set(into, 6);

            into = new(7);
            into.Set("a3", 1);
            into.Set("b3", 2);
            into.Set("c3", 3);
            into.Set("d3", 4);
            into.Set("e3", 5);
            into.Set("f3", 6);
            into.Set("g3", 7);
            matrix.Set(into, 7);

            string det = en.Det(matrix).FullSimplify().Text;

            // int max = 7;
            // for (int i1 = 0; i1 < Math.Pow(2, max); i1++)
            // {
            //     int[] bitString1 = [.. Convert.ToString(i1, 2).PadLeft(max, '0').ToArray().Select(x => x == '0' ? 0 : 1)];
            //     Matrix<int> into1 = new(max);
            //     for (int j = 0; j < bitString1.Length; j++)
            //         into1.Set(bitString1[j], j + 1);
            //     matrix.Set(into1, 6);

            //     for (int i2 = 0; i2 < Math.Pow(2, max); i2++)
            //     {
            //         int[] bitString2 = [.. Convert.ToString(i2, 2).PadLeft(max, '0').ToArray().Select(x => x == '0' ? 0 : 1)];
            //         Matrix<int> into2 = new(max);
            //         for (int j = 0; j < bitString2.Length; j++)
            //             into2.Set(bitString2[j], j + 1);
            //         matrix.Set(into2, 7);

            //         // for (int i3 = 0; i3 < Math.Pow(2, max); i3++)
            //         // {
            //         //     int[] bitString3 = [.. Convert.ToString(i3, 2).PadLeft(max, '0').ToArray().Select(x => x == '0' ? 0 : 1)];
            //         //     Matrix<int> into3 = new(max);
            //         //     for (int j = 0; j < bitString3.Length; j++)
            //         //         into3.Set(bitString3[j], j + 1);
            //         //     matrix.Set(into3, 7);

            //         //     string res = en.Det(matrix).Text;

            //         //     if (!res.Equals("0"))
            //         //         Console.WriteLine(into1 + "#" + into2 + "#" + into3);
            //         // }

            //         string res = en.Det(matrix).Text;

            //         if (!res.Equals("0"))
            //             Console.WriteLine(into1 + "#" + into2);
            //     }
            // }
        }

        private static void Five_x_five()
        {
            Engine en = new();

            Matrix<int> matrix = new(5, 5);
            Matrix<int> into = new(5);
            into.Set(1, 1);
            into.Set(1, 2);
            matrix.Set(into, 1);

            into = new(5);
            into.Set(1, 3);
            into.Set(1, 4);
            matrix.Set(into, 2);

            into = new(5);
            into.Set(1, 2);
            into.Set(1, 4);
            into.Set(1, 5);
            matrix.Set(into, 3);

            into = new(5);
            into.Set(1, 1);
            into.Set(1, 2);
            into.Set(1, 3);
            into.Set(1, 4);
            matrix.Set(into, 4);

            int max = 5;
            for (int i1 = 0; i1 < Math.Pow(2, max); i1++)
            {
                int[] bitString1 = [.. Convert.ToString(i1, 2).PadLeft(max, '0').ToArray().Select(x => x == '0' ? 0 : 1)];
                Matrix<int> into1 = new(max);
                for (int j = 0; j < bitString1.Length; j++)
                    into1.Set(bitString1[j], j + 1);
                matrix.Set(into1, 5);

                string res = en.Det(matrix).Text;

                if (!res.Equals("0"))
                    Console.WriteLine(into1);
            }
        }

        public static void Main()
        {
            Seven_x_seven();
            // Five_x_five();
        }
    }
}