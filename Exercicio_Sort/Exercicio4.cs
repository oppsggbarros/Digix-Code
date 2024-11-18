using System;
using System.Linq;

namespace Aula_11
{
    public class InsertionSort
    {
        // Função para ordenar de forma crescente usando Insertion Sort
        static void Ordenar(int[] vetor)
        {
            int aux, j;
            for (int i = 1; i < vetor.Length; i++)
            {
                aux = vetor[i];
                j = i - 1;

                // Desloca os elementos para a direita até encontrar a posição correta
                while (j >= 0 && vetor[j] > aux)
                {
                    vetor[j + 1] = vetor[j];
                    j--;
                }
                vetor[j + 1] = aux;
            }
        }

        static void Imprimir(int[] vetor)
        {
            // Imprime o vetor em uma única linha
            foreach (var item in vetor)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void ain(string[] args)
        {
            
            Console.WriteLine("Digite uma lista de números inteiros separados por vírgula:");
            string lista = Console.ReadLine();

            
            int[] vetor = lista.Split(',').Select(n => Convert.ToInt32(n)).ToArray();

            
            Console.WriteLine("\nVetor desordenado:");
            Imprimir(vetor);

            
            Ordenar(vetor);

            
            Console.WriteLine("\nVetor ordenado:");
            Imprimir(vetor);
        }
    }
}
