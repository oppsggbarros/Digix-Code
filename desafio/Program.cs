using System;

namespace desafio
{
    class Program
    {
        
        public delegate int SomaFabrica(int[,] valores);

        
        static int SomaProducaoFabrica(int[,] valores)
        {
            int soma = 0;
            for (int i = 0; i < valores.GetLength(0); i++)
            {
                for (int j = 0; j < valores.GetLength(1); j++)
                {
                    soma += valores[i, j];
                }
            }
            return soma;
        }

        static void Main(string[] args)
        {
            int[,,] producao = new int[3, 2, 7]; 

            
            int l = 1;
            for (int i = 0; i < producao.GetLength(0); i++)
            {
                Console.WriteLine($"Fábrica {l++}");
                for (int j = 0; j < producao.GetLength(1); j++)
                {
                    for (int k = 0; k < producao.GetLength(2); k++)
                    {
                        Console.WriteLine($"Digite a quantidade de unidades produzidas na Semana {j + 1} Dia {k + 1}:");
                        producao[i, j, k] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            
            l = 1;
            for (int i = 0; i < producao.GetLength(0); i++)
            {
                int[,] fabricaProducao = new int[producao.GetLength(1), producao.GetLength(2)];

                
                for (int j = 0; j < producao.GetLength(1); j++)
                {
                    for (int k = 0; k < producao.GetLength(2); k++)
                    {
                        fabricaProducao[j, k] = producao[i, j, k];
                    }
                }

                
                SomaFabrica somaFabrica = new SomaFabrica(SomaProducaoFabrica);
                int soma = somaFabrica(fabricaProducao);

                Console.WriteLine($"\nSoma da produção da Fábrica {i + 1}: {soma}");
            }

            
            l = 1;
            for (int i = 0; i < producao.GetLength(0); i++)
            {
                Console.WriteLine($"\nFábrica {l++}");
                for (int j = 0; j < producao.GetLength(1); j++)
                {
                    for (int k = 0; k < producao.GetLength(2); k++)
                    {
                        Console.Write($"{producao[i, j, k]}  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
