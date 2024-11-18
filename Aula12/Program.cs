using System;

namespace Aula12
{
    public class Program
    {
        static void Ordenar(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int p = Particionar(vetor, inicio, fim);
                Ordenar(vetor, inicio, p - 1);
                Ordenar(vetor, p + 1, fim);
            }
        }

        static int Particionar(int[] vetor, int inicio, int fim)
        {
            int pivo = vetor[fim];
            int i = inicio - 1;

            for (int j = inicio; j < fim; j++)
            {
                if (vetor[j] < pivo)
                {
                    i++;
                    
                    int aux = vetor[i];
                    vetor[i] = vetor[j];
                    vetor[j] = aux;
                }
            }

            
            int aux2 = vetor[i + 1];
            vetor[i + 1] = vetor[fim];
            vetor[fim] = aux2;

            return i + 1;
        }

        public static void Mai(string[] args)
        {
            int[] vetor = {10, 7, 8, 9, 1, 5 };
            Console.WriteLine("Vetor original: " + string.Join(", ", vetor));

            Ordenar(vetor, 0, vetor.Length - 1);

            Console.WriteLine("Vetor ordenado: " + string.Join(", ", vetor));
        }
    }
}
