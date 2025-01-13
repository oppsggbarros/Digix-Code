using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Aula26_ManipulaçãoArquivo
{
    public class Exemplo5
    {
        static void n(string[] args)
        {
            string path = @"C:\Users\gabrielgravena\Desktop\test";
            try
            {
                IEnumerable<string> pastas =Directory.EnumerateDirectories(path, "*.*",
                SearchOption.AllDirectories);
                Directory.CreateDirectory(path + @"\Test23");
                System.Console.WriteLine("Pastas:");
                foreach(string item in pastas)
                {
                    System.Console.WriteLine(item);
                }
                IEnumerable<string> arquivos = Directory.EnumerateFiles(path, "*,*", SearchOption.AllDirectories);
                foreach (string item in arquivos)
                {
                    System.Console.WriteLine(item);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}