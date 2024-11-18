using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_11
{
    public class BubleSort
    {
                static void Ordenar(int[] vetor)
        {
            int aux;
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
        }
        static void Imprimir(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                System.Console.WriteLine(vetor[i] + " ");
            }
            System.Console.WriteLine();
        }
        static void Mai(string[] args)
        {
            Console.WriteLine("Digite uma lista de números inteiros separados por virgula:");
            string input = Console.ReadLine();
            int[] vetor = input.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            System.Console.WriteLine("Vetor desordenado");
            Imprimir(vetor);
            Ordenar(vetor);
            System.Console.WriteLine("Vetor ordenado");
            Imprimir(vetor);

        }
    }
}