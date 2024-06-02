// using CoreWolf;
// using CoreWolf.Types;

// namespace WolfTest
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             Link link = new();
//             Engine en = link.Engine;

//             CoreWolf.Types.Matrix<ZeroString> array = new(4, 4);
//             array.Set("a", 2, 3);
//             array.Set("b", 1, 2);
//             array.Set("c", 2, 1);
//             array.Set("d", 2, 2);
//             array.Set("e", 4, 4);
//             array.Set("f", 1, 3);
//             string res = en.Det(array).Text;

//             CoreWolf.Types.Array<ZeroString> vect = new(3);
//             vect.Add("x");
//             vect.Add("0");
//             vect.Add("1");
//             en.Integrate("x^2", vect);

//             //for (int j = 0; j < 1000; j++)
//             Parallel.ForEach(Enumerable.Range(0, 100), j =>
//             {
//                 Link link = new();
//                 Engine en = link.Engine;
//                 Random rnd = new();
//                 for (int i = 0; i < 100; i++)
//                 {
//                     double r1 = rnd.NextDouble();
//                     double r2 = rnd.NextDouble();
//                     Console.WriteLine(double.Parse(en.Execute(r1 + "+" + r2).ToString()).Equals(r1 + r2).ToString().ToString());  //use the engine to Execute a command
//                 }

//                 // if (j % 2 == 1)
//                 //     link.Dispose();
//                 // link.Close();
//             });
//         }
//     }
// }