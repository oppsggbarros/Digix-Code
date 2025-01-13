// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula26_ManipulaçãoArquivo
// {
//     public class Exemplo4
//     {
//         static void Main (string[] args)
//         {
//             string inicioPath = @"C:\Users\gabrielgravena\Desktop\Test1.txt";
//             string finalPath = @"C:\Users\gabrielgravena\Desktop\Test2.txt";

//             try
//             {
//                 string []lines = File.ReadAllLines(inicioPath);
//                 using (StreamWriter sw =File.AppendText(finalPath))
//                 {
//                     foreach (string line in lines)
//                     {
//                         sw.WriteLine(line.Reverse().ToArray());
//                     }
//                 }
//             }
//             catch (IOException e)
//             {
//                 Console.WriteLine("Erro ao realizar a operação: " + e.Message);
//             }
//     }
// }}