
using System;

namespace Aula_7
{
    class Program2
    {
        static void Main(string[] args)
        {
            // Exercicio 1 
            // int [] vetor = new int[10];
            // int i = 0;
            // Console.WriteLine("Digite 10 valores inteiros");
            // for (i = 0; i < 10; i++)
            // {
            //     vetor[i] = Convert.ToInt32(Console.ReadLine());
            // }
            // int media = 0;
            // for (i = 0; i < 10; i++)
            // {
            //     media += vetor[i];
                
            // }
            // media = media/10;
            // Console.WriteLine($"A média dos valores é {media}");

            // Exercicio 2
            int[,] matriz = new int[4, 4]{
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
            };
            int somal1 = 0;
            int somal2 = 0;
            int somal3 = 0;
            int somal4 = 0;
            int i = 0;
            for (int j = 0; j < 4; j++) 
            {
                somal1 += matriz[i, j];
            }
            for (int j = 0; j < 4; j++)
            {
                i = 1;
                somal2 += matriz[i, j];
            } 
            for (int j = 0; j < 4; j++)
            {
                i = 2;
                somal3 += matriz[i, j];
            }
            for(int j = 0; j < 4; j++)
            {
                i = 3;
                somal4 += matriz[i, j];
            
            }   

            Console.WriteLine($"Soma da linha 1 é :{somal1}");
            Console.WriteLine($"Soma da linha 2 é :{somal2}");
            Console.WriteLine($"Soma da linha 3 é :{somal3}");
            Console.WriteLine($"Soma da linha 4 é :{somal4}");

            //Exercicio 3
            // int[] vetor = { 1, 2, 3, 2, 1 };
            // bool resposta = true; 

            // int tamanho = vetor.Length;
            // for (int i = 0; i < tamanho / 2; i++)
            // {
            //     if (vetor[i] != vetor[tamanho - 1 - i])
            //     {
            //         resposta = false;
            //         break; 
            //     }
            // }
            
            // if (resposta)
            // {
            //     Console.WriteLine("É Palíndromo");
            // }
            // else
            // {
            //     Console.WriteLine("Não é Palíndromo");
            // }

            // Exercicio 4
            // int[,] matriz = new int [3, 3] {
            // {1, 2, 3},
            // {4, 5, 6},
            // {7, 8, 9}
            // };
            // int somaDiagonalP = 0;
            // int n = matriz.GetLength(0);
            // for (int i = 0; i < n; i++)
            // {
            //     somaDiagonalP += matriz[i, i];
            // }
            // Console.WriteLine($"Soma da diagonal principal é :{somaDiagonalP}");
            // int somaDiagonalS = 0;
            // for (int i = 0; i < n; i++)
            // {
            //     somaDiagonalS += matriz[i, n - i];
            // }
            // Console.WriteLine($"Soma da diagonal secundária é :{somaDiagonalS}");


            // Exercicio 5
            // int[,] matriz = {
            // { 1, 2, 3, 4 },
            // { 5, 6, 7, 8 },
            // { 9, 10, 11, 12 },
            // { 13, 14, 15, 16 }
            // };

            // int n = matriz.GetLength(0);

            // int[,] matrizRotacionada = new int[n, n];

            // for (int i = 0; i < n; i++)
            // {
            //     for (int j = 0; j < n; j++)
            //     {
            //         matrizRotacionada[j, n - 1 - i] = matriz[i, j];
            //     }
            // }

            // Console.WriteLine("\nMatriz rotacionada 90 graus no sentido horário:");
            // for (int i = 0; i < n; i++)
            // {
            //     for (int j = 0; j < n; j++)
            //     {
            //         Console.Write(matrizRotacionada[i, j] + " ");
            //     }
            //     Console.WriteLine();
            // }
        }
    }
}
