using System;
namespace Aula7
{
    class Program
    {   
        static int soma(int a, int b)
        {
            return a + b;
        }
        static int somamatriz(int[,] matriz)
        {
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i, j];

                }
            }
            return soma;
        }
        static void  a(string[] args)
        {
            // int a = 10;
            // int b = 20;
            // int resultado = soma(a, b);
            // Console.WriteLine("O resultado da soma é: " + resultado);
            int[,] matriz = { { 1, 2, 3 }, { 4,  5, 6 }, { 7, 8, 9 } };
            int resultado = somamatriz(matriz);
            Console.WriteLine("O resultado da soma é: " + resultado);


        }    

    }
}