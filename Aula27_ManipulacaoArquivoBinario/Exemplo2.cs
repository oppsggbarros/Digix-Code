using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula27_ManipulacaoArquivoBinario
{
    public class Exemplo2
    {
        static void Min(string[] args)
        {
            string filePath = "dados.bin";
            using(BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                int inteiro = reader.ReadInt32();
                double numeroReal = reader.ReadDouble();
                string texto = reader.ReadString();
            
                System.Console.WriteLine("Numero int do arquivo: " + inteiro);
                System.Console.WriteLine("Numero real do arquivo: " + numeroReal);
                System.Console.WriteLine("Texto do arquivo: " + texto);
            }
        }
    }
}