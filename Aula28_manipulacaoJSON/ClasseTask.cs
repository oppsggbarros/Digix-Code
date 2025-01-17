// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula28_manipulacaoJSON
// {
//     public class ClasseTask
//     {
//         static async Task Main(string[] args)
//         {
//             System.Console.WriteLine("Inicio do programa");
//             int resultado = await Soma(10, 20);
//             System.Console.WriteLine("Resultado da soma: " + resultado);
//         }

//         static Task<int> Soma(int a , int b)
//         {
//             return Task.Run(() => {
//                 Task.Delay(2000).Wait();
//                 return a + b;
//             });
//         }
//     }
// }