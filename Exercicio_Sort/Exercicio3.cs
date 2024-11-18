using System;

namespace SelectionSortStrings
{
    class Program
    {
        static void Ordenar(string[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                
                int menorIndice = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (string.Compare(array[j], array[menorIndice], StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        menorIndice = j;
                    }
                }

                
                if (menorIndice != i)
                {
                    string temp = array[i];
                    array[i] = array[menorIndice];
                    array[menorIndice] = temp;
                }
            }
        }

        static void Imprimir(string[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void ain(string[] args)
        {
            Console.WriteLine("Digite uma lista de palavras separadas por vírgulas:");
            string entrada = Console.ReadLine();           
            string[] palavras = entrada.Split(',');

            Console.WriteLine("\nArray desordenado:");
            Imprimir(palavras);

            
            Ordenar(palavras);

            Console.WriteLine("\nArray ordenado:");
            Imprimir(palavras);
        }
    }
}
