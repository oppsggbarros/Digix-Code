// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula26_ManipulaçãoArquivo
// {
//     public class Exemplo2
//     {
//         static void Main (string[] args)
//         {
//             string inicioPath = @"C:\Users\gabrielgravena\Desktop\Test1.txt";
//             FileStream fs = null;
//             StreamReader sr = null;
            
//             // string finalFile = @"C:\Users\gabrielgravena\Desktop\Test2.txt";
//             try
//             {
//                 fs =  new FileStream(inicioPath, FileMode.Open);
//                 sr = new StreamReader(fs);
//                 string line = sr.ReadLine();
//                 System.Console.WriteLine(line);
//             }
//             catch(IOException e)
//             {
//                 System.Console.WriteLine("Erro ao abrir o arquivo");
//                 System.Console.WriteLine(e.Message);
//             }
//             finally
//             {
//                 if (sr != null) sr.Close();
//                 if (fs != null) fs.Close();

//             }

//         }
//     }
// }