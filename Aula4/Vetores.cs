using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
namespace exercicio
{
    internal class Produtos
    {
        static void Main (String[] args)
        {
            // int [] vetor1 = new int[4];
            // int [] vetor2 = {1, 2, 3, 4, 5};
            // int [] vetor3 = new int[] {1, 2, 3, 4, 5};
            // int [] vetor4 = {};

        //     int[] x = new int[10];
        //     int i;
        //     Console.WriteLine("Digite 10 valores inteiros");
        //     for (i = 0; i < 10; i++)
        //         x[i] = int.Parse(Console.ReadLine());
        //         Console.WriteLine("Ordem inversa");
        //     for (i = 9; i >= 0; i--)
        //         Console.WriteLine(x[i]);
        //         Console.ReadKey();
            Random r = new Random();
            int[] vetor = new int[10] { r.Next(10), r.Next(10), r.Next(10), r.Next(10), r.Next(10), r.Next(10), r.Next(10), r.Next(10), r.Next(10), r.Next(10) };
            Console.WriteLine(string.Join(", ", vetor));
            Console.WriteLine(vetor);

            int maior = vetor.Max();
            int menor = vetor.Min();

            Console.WriteLine("Maior valor: " + maior);
            Console.WriteLine("Menor valor: " + menor);

        }
    }
}