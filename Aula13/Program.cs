using System;
namespace Aula_13
{
    class Listass
    {
        public class Lista
        {
            static int [] vetor = new int[10];
            
            static void Inserir(int valor)
            {
                for (int i = 0; i < vetor.Length; i++)
                {
                    if (vetor[i] == 0)
                    {
                        vetor[i] = valor;
                        break;
                    }
                }
            }
        }
        static void Listar()
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] != 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }
        static void ListaInversa()
        {
            
        }
        
        // static void Main(string[] args)
        // {
        //     List<string> names = ["Eu", "Ana", "Felipe"];
        //     foreach (var name in names)
        //     {
        //         Console.WriteLine($"Hello {name}!");
        //     }
        //     Console.WriteLine();
        //     names.Add("Maria");
        //     names.Add("Will");
        //     names.Remove("Ana");
        //     foreach (var name in names)
        //     {
        //         Console.WriteLine($"Hello {name}!");
        //     }
        // }
    }
}