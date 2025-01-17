using System;
using System.Collections.Generic;
using System.IO;

namespace Exercicio17_01
{
    public class Exercicio_matriz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de linhas da matriz: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número de colunas da matriz: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int[,] matriz = new int[l, c];
            Random rand = new Random();

            
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matriz[i, j] = rand.Next(1, 101);
                }
            }

            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1 - Imprimir a matriz");
            Console.WriteLine("2 - Imprimir a soma das linhas");
            Console.WriteLine("3 - Imprimir a soma das colunas");
            Console.WriteLine("4 - Imprimir a matriz transposta");
            int opcao = Convert.ToInt32(Console.ReadLine());
            string path = "resultado.csv";

            switch (opcao)
            {
                case 1:
                    ImprimirMatriz(matriz, l, c, path);
                    break;

                case 2:
                    ImprimirSomaDasLinhas(matriz, l, c, path);
                    break;

                case 3:
                    ImprimirSomaDasColunas(matriz, l, c, path);
                    break;

                case 4:
                    ImprimirMatrizTransposta(matriz, l, c, path);
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        static void ImprimirMatriz(int[,] matriz, int l, int c, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < l; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        sw.Write(matriz[i, j]);
                        if (j < c - 1) sw.Write(",");
                    }
                    sw.WriteLine();
                }
            }
            
        }

        static void ImprimirSomaDasLinhas(int[,] matriz, int l, int c, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Linha,Soma");
                for (int i = 0; i < l; i++)
                {
                    int soma = 0;
                    for (int j = 0; j < c; j++)
                    {
                        soma += matriz[i, j];
                    }
                    sw.WriteLine($"{i + 1},{soma}");
                }
            }
        }

        static void ImprimirSomaDasColunas(int[,] matriz, int l, int c, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Coluna,Soma");
                for (int j = 0; j < c; j++)
                {
                    int soma = 0;
                    for (int i = 0; i < l; i++)
                    {
                        soma += matriz[i, j];
                    }
                    sw.WriteLine($"{j + 1},{soma}");
                }
            }
        }

        static void ImprimirMatrizTransposta(int[,] matriz, int l, int c, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int j = 0; j < c; j++)
                {
                    for (int i = 0; i < l; i++)
                    {
                        sw.Write(matriz[i, j]);
                        if (i < l - 1) sw.Write(",");
                    }
                    sw.WriteLine();
                }
            }
        }
    }
}
