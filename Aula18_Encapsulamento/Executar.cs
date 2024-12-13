// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Reflection;
// using System.Threading.Tasks;

// namespace Aula18_Encapsulamento
// {
//     public class Executar
//     {
//         static void Maain(string[] args)
//         {
//             Produto p = new Produto("Bomba Atomica", 10000);
//             p.Nome = "Bomba nuclear";
//             p.Preco = 1000000;
//             p.Quantidade = 10;
//             Console.WriteLine(p.Nome + " - " + p.Preco + " - " + p.Quantidade);
//             System.Console.WriteLine(p);
//             Type t = typeof(Produto);
//             Console.WriteLine("Propriedades: ");
//             foreach (PropertyInfo prop in)
//             {
//                 Console.WriteLine(prop.Name);
//             }
//         }
//     }
// }