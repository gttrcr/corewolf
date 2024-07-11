using CoreWolf;
using CoreWolf.Types;

namespace Test
{
    public class Program
    {
        // private static void Seven_x_seven()
        // {
        //     Engine en = new();

        //     Matrix<int> matrix = new(7, 7);
        //     Matrix<int> into = new(7);
        //     into.Set(1, 1);
        //     into.Set(1, 2);
        //     into.Set(1, 3);
        //     into.Set(1, 4);
        //     matrix.Set(into, 1);

        //     into = new(7);
        //     into.Set(1, 2);
        //     into.Set(1, 4);
        //     into.Set(1, 5);
        //     into.Set(1, 6);
        //     matrix.Set(into, 2);

        //     into = new(7);
        //     into.Set(1, 3);
        //     into.Set(1, 4);
        //     into.Set(1, 6);
        //     into.Set(1, 7);
        //     matrix.Set(into, 3);

        //     into = new(7);
        //     into.Set(1, 1);
        //     into.Set(1, 3);
        //     into.Set(1, 5);
        //     into.Set(1, 6);
        //     matrix.Set(into, 4);

        //     // into = new(7);
        //     // into.Set(1, 1);
        //     // into.Set(1, 5);
        //     // into.Set(-2, 7);
        //     // matrix.Set(into, 5);

        //     // into = new(7);
        //     // into.Set(1, 2);
        //     // into.Set(-1, 7);
        //     // matrix.Set(into, 6);

        //     int max = 7;
        //     for (int i1 = 0; i1 < Math.Pow(2, max); i1++)
        //     {
        //         int[] bitString1 = [.. Convert.ToString(i1, 2).PadLeft(max, '0').ToArray().Select(x => x == '0' ? 0 : 1)];
        //         Matrix<int> into1 = new(max);
        //         for (int j = 0; j < bitString1.Length; j++)
        //             into1.Set(bitString1[j], j + 1);
        //         matrix.Set(into1, 7);

        //         for (int i2 = 0; i2 < Math.Pow(2, max); i2++)
        //         {
        //             int[] bitString2 = [.. Convert.ToString(i2, 2).PadLeft(max, '0').ToArray().Select(x => x == '0' ? 0 : 1)];
        //             Matrix<int> into2 = new(max);
        //             for (int j = 0; j < bitString2.Length; j++)
        //                 into2.Set(bitString2[j], j + 1);
        //             matrix.Set(into2, 7);

        //             for (int i3 = 0; i3 < Math.Pow(2, max); i3++)
        //             {
        //                 int[] bitString3 = [.. Convert.ToString(i3, 2).PadLeft(max, '0').ToArray().Select(x => x == '0' ? 0 : 1)];
        //                 Matrix<int> into3 = new(max);
        //                 for (int j = 0; j < bitString3.Length; j++)
        //                     into3.Set(bitString3[j], j + 1);
        //                 matrix.Set(into3, 7);

        //                 string res = en.Det(matrix).Text;

        //                 if (!res.Equals("0") && into1.Get(1) == into1.Get(5) && into1.Get(3) == into1.Get(6) && into2.Get(1) == into2.Get(5) && into2.Get(3) == into2.Get(6) && into3.Get(1) == into3.Get(5) && into3.Get(3) == into3.Get(6))
        //                     Console.WriteLine(into1 + "#" + into2 + "#" + into3);
        //             }

        //             // string res = en.Det(matrix).Text;

        //             // if (!res.Equals("0"))
        //             //     Console.WriteLine(into1 + "#" + into2);
        //         }

        //         // string res = en.Det(matrix).Text;

        //         // if (!res.Equals("0"))
        //         //     Console.WriteLine(into1);
        //     }
        // }

        // private static void Five_x_five()
        // {
        //     Engine en = new();

        //     Matrix<int> matrix = new(5, 5);
        //     Matrix<int> into = new(5);
        //     into.Set(1, 1);
        //     into.Set(1, 2);
        //     matrix.Set(into, 1);

        //     into = new(5);
        //     into.Set(1, 3);
        //     into.Set(1, 4);
        //     matrix.Set(into, 2);

        //     into = new(5);
        //     into.Set(1, 2);
        //     into.Set(1, 4);
        //     into.Set(1, 5);
        //     matrix.Set(into, 3);

        //     into = new(5);
        //     into.Set(1, 1);
        //     into.Set(1, 2);
        //     into.Set(1, 3);
        //     into.Set(1, 4);
        //     matrix.Set(into, 4);

        //     int max = 5;
        //     for (int i1 = 0; i1 < Math.Pow(2, max); i1++)
        //     {
        //         int[] bitString1 = [.. Convert.ToString(i1, 2).PadLeft(max, '0').ToArray().Select(x => x == '0' ? 0 : 1)];
        //         Matrix<int> into1 = new(max);
        //         for (int j = 0; j < bitString1.Length; j++)
        //             into1.Set(bitString1[j], j + 1);
        //         matrix.Set(into1, 5);

        //         string res = en.Det(matrix).Text;

        //         if (!res.Equals("0"))
        //             Console.WriteLine(into1);
        //     }
        // }

        public static void Main()
        {
            // Seven_x_seven();
            // Five_x_five();

            Engine en = new();
            double entropy = en.Entropy("{0, 2, 5}", null).N().Result<double>();
        }
    }
}