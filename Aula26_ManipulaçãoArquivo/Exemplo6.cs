using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula26_ManipulaçãoArquivo
{
    public class Exemplo6
    {
        static void Man(string[] args)
        {
            string inicioPath = @"C:\Users\gabrielgravena\Desktop\test";
            System.Console.WriteLine("Directory Separator CHar" + Path.DirectorySeparatorChar);
            System.Console.WriteLine("Separador de caminho:" + Path.PathSeparator);
            System.Console.WriteLine("Retorna o diretorio do arquivo: " + Path.GetDirectoryName(inicioPath));
            System.Console.WriteLine("Retorna o nome do arquivo: " + Path.GetFileName(inicioPath));
            System.Console.WriteLine("Retorna o nome do arquivo sem a extensão: " + Path.GetFileNameWithoutExtension(inicioPath));
            System.Console.WriteLine("Retorna a extensão do arquivo: " + Path.GetExtension(inicioPath));
        }
    }
}