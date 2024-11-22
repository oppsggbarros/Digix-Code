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

        
        static void MergeSort(int[] array)
        {
            if (array.Length <= 1)
                return;

            int mid = array.Length / 2;

            
            int[] left = array.Take(mid).ToArray();
            int[] right = array.Skip(mid).ToArray();

            
            MergeSort(left);
            MergeSort(right);

            
            Merge(array, left, right);
        }

        static void Merge(int[] array, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    array[k++] = left[i++];
                }
                else
                {
                    array[k++] = right[j++];
                }
            }

            
            while (i < left.Length)
            {
                array[k++] = left[i++];
            }

            
            while (j < right.Length)
            {
                array[k++] = right[j++];
            }
        }
        // Quick Sort
static void QuickSort(int[] array, int low, int high)
{
    if (low < high)
    {
        
        int pi = Partition(array, low, high);

        
        QuickSort(array, low, pi - 1);
        QuickSort(array, pi + 1, high);
    }
}

        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1; 

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            
            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }


        static void Man(string[] args)
        {
            
            Random rand = new Random();
            int[] array = new int[100000];
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

           
            int[] mergeArray = (int[])array.Clone();
            stopwatch.Restart();
            MergeSort(mergeArray);
            stopwatch.Stop();
            Console.WriteLine($"Merge Sort levou {stopwatch.ElapsedMilliseconds} ms.");

            
            int[] quickArray = (int[])array.Clone();
            stopwatch.Restart();
            QuickSort(quickArray, 0, quickArray.Length - 1);
            stopwatch.Stop();
            Console.WriteLine($"Quick Sort levou {stopwatch.ElapsedMilliseconds} ms.");

        }
    }
}
