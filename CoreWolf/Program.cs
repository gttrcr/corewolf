﻿// using CoreWolf;

// namespace WolfTest
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             for (int j = 0; j < 1000; j++)
//             {
//                 Link link = new();
//                 Engine en = link.Engine;
//                 Random rnd = new();
//                 for (int i = 0; i < 1000; i++)
//                 {
//                     double r1 = rnd.NextDouble();
//                     double r2 = rnd.NextDouble();
//                     Console.WriteLine(double.Parse(en.Execute(r1 + "+" + r2).ToString()).Equals(r1 + r2).ToString().ToString());  //use the engine to Execute a command
//                 }
//             }
//         }
//     }
// }