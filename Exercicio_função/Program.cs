using System;
using System.Linq;

class Program
{
    static bool VerificarPalindromo(int[] vetor)
    {
        int tamanho = vetor.Length;
        for (int i = 0; i < tamanho / 2; i++)
        {
            if (vetor[i] != vetor[tamanho - 1 - i])
            {
                return false;
            }   
        }
        return true; 
    }
    public static (int, int) Diagonais(int[,] matriz)
    {
        int n = matriz.GetLength(0); 
        int DiagonalPrincipal = 0;
        int DiagonalSecundaria = 0;

        for (int i = 0; i < n; i++)
        {
            DiagonalPrincipal += matriz[i, i]; 
            DiagonalSecundaria += matriz[i, n - 1 - i]; 
        }

        return (DiagonalPrincipal, DiagonalSecundaria);
    }
    private static void RotaçãoMatrix(ref int[,] matriz)
    {
        int n = matriz.GetLength(0);  

        
        int[,] matrizRotacionada = new int[n, n];

        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrizRotacionada[j, n - 1 - i] = matriz[i, j];
            }
        }

        
        matriz = matrizRotacionada;
    }
    public static void Matrix(int[,] matriz)
    {
        int n = matriz.GetLength(0);  

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matriz[i, j] + "\t");  
            }
            Console.WriteLine();  
        }
    }

    static void Main()
    {

        //Exercicio 1
        // double[] numeros = new double[10];
        // Console.WriteLine("Digite 10 números:");

        // for (int i = 0; i < 10; i++)
        // {
        //     Console.Write($"Número {i + 1}: ");
        //     numeros[i] = Convert.ToDouble(Console.ReadLine());
        // }

        // Func<double[], double> calcularMedia = delegate (double[] nums)
        // {
        //     return nums.Average();
        // };

        // double media = calcularMedia(numeros);

        // Console.WriteLine($"A média dos números inseridos é: {media}");

        //Exercicio 2
        // int[,] matriz = {
        //     { 1, 2, 3, 4 },
        //     { 5, 6, 7, 8 },
        //     { 9, 10, 11, 12 },
        //     { 13, 14, 15, 16 }
        //     };
        // Action<int[]> rLinha = delegate (int[] linha)
        // {
        //     int  = 0;
        //     foreach (int valor in linha)
        //     {
        //          += valor;
        //     }
        //     Console.WriteLine($" da linha: {}");
        // };
        // for (int i = 0; i < 4; i++)
        // {
        //     int[] linha = new int[4];
        //     for (int j = 0; j < 4; j++)
        //     {
        //         linha[j] = matriz[i, j];
        //     }
        //     rLinha(linha);
        // }

        // Exercicio 3
        // int[] vetor = { 1, 2, 3, 2, 1 };

        // bool ehPalindromo = VerificarPalindromo(vetor);

        // if (ehPalindromo)
        // {
        //     Console.WriteLine("O vetor é um palíndromo.");
        // }
        // else
        // {
        //     Console.WriteLine("O vetor não é um palíndromo.");
        // }
        
        // Exercicio 4
        // int[,] matriz = new int [3, 3] {
        // {1, 2, 3},
        // {4, 5, 6},
        // {7, 8, 9}
        // };
        // var (DiagonalPrincipal, DiagonalSecundaria) = Diagonais(matriz);

        
        // Console.WriteLine($"A diagonal principal é: {DiagonalPrincipal}");
        // Console.WriteLine($"A diagonal secundaria é: {DiagonalSecundaria}");

        // Exercicio 5

        // int[,] matriz = {
        //     { 1, 2, 3 },
        //     { 4, 5, 6 },
        //     { 7, 8, 9 }
        // };

        // // Exibe a matriz original
        // Console.WriteLine("Matriz Original:");
        // Matrix(matriz);

        // // Realiza a rotação de 90 graus
        // RotaçãoMatrix(ref matriz);

        // // Exibe a matriz rotacionada
        // Console.WriteLine("\nMatriz Rotacionada 90 graus:");
        // Matrix(matriz);


        
    }
}
