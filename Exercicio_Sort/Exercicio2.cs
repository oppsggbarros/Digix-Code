using System;
using System.Linq;

namespace Aula_11
{
    public class Exrcicio2
    {
        static void Ordenar(int[] vetor)
        {
            int aux;
            bool trocou;

            for (int i = 0; i < vetor.Length; i++)
            {
                trocou = false;

                for (int j = 0; j < vetor.Length - 1 - i; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                        trocou = true;
                    }
                }

                
                if (!trocou) break;
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

        static void ain(string[] args)
        {
            try
            {
                Console.WriteLine("Digite uma lista de números inteiros separados por vírgula:");
                string lista = Console.ReadLine();
                int[] vetor = lista.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
                Console.WriteLine("Vetor desordenado:");
                Imprimir(vetor);
                Ordenar(vetor);

                Console.WriteLine("Vetor ordenado:");
                Imprimir(vetor);
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Certifique-se de digitar apenas números inteiros separados por vírgulas.");
            }
        }
    }
}
