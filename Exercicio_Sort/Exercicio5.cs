using System;
using System.Diagnostics;
using System.Linq;

namespace OrdenacaoComparacao
{
    class Program
    {
        static void BubbleSort(int[] array)
        {
            int aux;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        aux = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = aux;
                    }
                }
            }
        }

        
        static void SelectionSort(int[] array)
        {
            int menorIndice, aux;
            for (int i = 0; i < array.Length - 1; i++)
            {
                menorIndice = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[menorIndice])
                    {
                        menorIndice = j;
                    }
                }
                if (menorIndice != i)
                {
                    aux = array[i];
                    array[i] = array[menorIndice];
                    array[menorIndice] = aux;
                }
            }
        }

        
        static void InsertionSort(int[] array)
        {
            int aux, j;
            for (int i = 1; i < array.Length; i++)
            {
                aux = array[i];
                j = i - 1;
                while (j >= 0 && array[j] > aux)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = aux;
            }
        }

        static void Main(string[] args)
        {
            
            Random rand = new Random();
            int[] array = new int[1000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 10000); 
            }

            
            int[] bubbleArray = (int[])array.Clone();
            Stopwatch stopwatch = Stopwatch.StartNew();
            BubbleSort(bubbleArray);
            stopwatch.Stop();
            Console.WriteLine($"Bubble Sort levou {stopwatch.ElapsedMilliseconds} ms.");

            
            int[] selectionArray = (int[])array.Clone();
            stopwatch.Restart();
            SelectionSort(selectionArray);
            stopwatch.Stop();
            Console.WriteLine($"Selection Sort levou {stopwatch.ElapsedMilliseconds} ms.");

            
            int[] insertionArray = (int[])array.Clone();
            stopwatch.Restart();
            InsertionSort(insertionArray);
            stopwatch.Stop();
            Console.WriteLine($"Insertion Sort levou {stopwatch.ElapsedMilliseconds} ms.");
        }
    }
}
