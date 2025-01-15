using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula27_ManipulacaoArquivoBinario
{
    public class Exemplo1
    {
        static void Min(string[] args)
        {
            string filePath = "dados.bin";
            using(BinaryWriter writer = new
            BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(123);
                writer.Write(456.789);
                writer.Write("Teste :2");

            }
            System.Console.WriteLine("Dados gravados no: " + filePath);
        }
    }
}