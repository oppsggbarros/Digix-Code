using System;

namespace Aula12
{
    public class MergeSort
    {
        public static void Ordenar(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                // Calcula o índice do meio
                int meio = (inicio + fim) / 2;

                // Recursivamente ordena as duas metades
                Ordenar(vetor, inicio, meio);
                Ordenar(vetor, meio + 1, fim);

                // Mescla as duas metades ordenadas
                Merge(vetor, inicio, meio, fim);
            }
        }

        private static void Merge(int[] vetor, int inicio, int meio, int fim)
        {
            
            int[] aux = new int[vetor.Length];

            
            for (int i = inicio; i <= fim; i++)
            {
                aux[i] = vetor[i];
            }

            int i1 = inicio;     
            int i2 = meio + 1;   
            int i3 = inicio;     

            
            while (i1 <= meio && i2 <= fim)
            {
                if (aux[i1] <= aux[i2])
                {
                    vetor[i3] = aux[i1];
                    i1++;
                }
                else
                {
                    vetor[i3] = aux[i2];
                    i2++;
                }
                i3++;
            }

            
            while (i1 <= meio)
            {
                vetor[i3] = aux[i1];
                i1++;
                i3++;
            }

            
        }

        public static void Main(string[] args)
        {
            
            int[] vetor = {38, 27, 43, 3, 9, 82, 10 };

            Console.WriteLine("Vetor original: " + string.Join(", ", vetor));

           
            Ordenar(vetor, 0, vetor.Length - 1);

            Console.WriteLine("Vetor ordenado: " + string.Join(", ", vetor));
        }
    }
}
