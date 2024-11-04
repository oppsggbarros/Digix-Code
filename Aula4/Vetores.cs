// // using System;
// // using System.Linq;
// // using System.Collections.Generic;
// // using System.Security.Cryptography;
// // namespace exercicio
// // {
// //     internal class Produtos
// //     {
// //         static void Main (String[] args)
// //         {
// //             // int [] vetor1 = new int[4];
// //             // int [] vetor2 = {1, 2, 3, 4, 5};
// //             // int [] vetor3 = new int[] {1, 2, 3, 4, 5};
// //             // int [] vetor4 = {};

// //         //Exercicio 1
//             // int[] x = new int[10];
//             // int i;
//             // Console.WriteLine("Digite 10 valores inteiros");
//             // for (i = 0; i < 10; i++)
//             //     x[i] = Convert.ToInt32(Console.ReadLine());
//             //     Console.WriteLine("Ordem inversa");
//             // for (i = 9; i >= 0; i--)
//             //     Console.WriteLine(x[i]);
//             //     Console.ReadKey();
// //             //Exercicio 2

// //             // Random r = new Random();
// //             // int[] vetor = new int[10] { r.Next(10), r.Next(10), r.Next(10), r.Next(10), r.Next(10), r.Next(10), r.Next(10), r.Next(10), r.Next(10), r.Next(10) };
// //             // Console.WriteLine(string.Join(", ", vetor));
// //             // Console.WriteLine(vetor);

// //             // int maior = vetor.Max();
// //             // int menor = vetor.Min();

// //             // Console.WriteLine("Maior valor: " + maior);
// //             // Console.WriteLine("Menor valor: " + menor);
        
// //         // Exercicio 3
// //             // int[,] matriz = new int[4, 4];
// //             // Console.WriteLine("Digite os elementos da matriz 4x4:");
// //             // for (int i = 0; i < 4; i++)
// //             // {
// //             //     for (int j = 0; j < 4; j++)
// //             //     {
// //             //         Console.Write($"Elemento [{i + 1},{j + 1}]: ");
// //             //         matriz[i, j] = Convert.ToInt32(Console.ReadLine());
// //             //     }
// //             // }

            
// //             // int menor = matriz[0, 0];
// //             // int maior = matriz[0, 0];

            
// //             // for (int i = 0; i < 4; i++)
// //             // {
// //             //     for (int j = 0; j < 4; j++)
// //             //     {
// //             //         if (matriz[i, j] < menor)
// //             //             menor = matriz[i, j];
                    
// //             //         if (matriz[i, j] > maior)
// //             //             maior = matriz[i, j];
// //             //     }
// //             // }

            
// //             // int soma = maior + menor;

            
// //             // Console.WriteLine($"O menor elemento é: {menor}");
// //             // Console.WriteLine($"O maior elemento é: {maior}");
// //             // Console.WriteLine($"A soma do maior com o menor elemento é: {soma}");

// //             // Exercicio 4

//             // int[,] matriz = new int[4, 4];
        
//             // Console.WriteLine("Digite os elementos da matriz 4x4:");
//             // for (int i = 0; i < 4; i++)
//             // {
//             //     for (int j = 0; j < 4; j++)
//             //     {
//             //         Console.Write($"Elemento [{i + 1},{j + 1}]: ");
//             //         matriz[i, j] = Convert.ToInt32(Console.ReadLine());
//             //     }
//             // }

            
//             // int somaDiagonal = 0;
//             // for (int i = 0; i < 4; i++)
//             // {
//             //     somaDiagonal += matriz[i, i];
//             // }

            
//             // Console.WriteLine($"A soma dos elementos da diagonal principal é: {somaDiagonal}");

// //             //Exercicio 5

//             // int[,] matriz1 = new int[4, 4];
//             // int[,] matriz2 = new int[4, 4];
//             // int[,] somaMatriz = new int[4, 4];

//             // Console.WriteLine("Digite os elementos da primeira matriz 4x4:");
//             // for (int i = 0; i < 4; i++)
//             // {
//             //     for (int j = 0; j < 4; j++)
//             //     {
//             //         Console.Write($"Elemento [{i + 1},{j + 1}]: ");
//             //         matriz1[i, j] = Convert.ToInt32(Console.ReadLine());
//             //     }
//             // }

//             // Console.WriteLine("Digite os elementos da segunda matriz 4x4:");
//             // for (int i = 0; i < 4; i++)
//             // {
//             //     for (int j = 0; j < 4; j++)
//             //     {
//             //         Console.Write($"Elemento [{i + 1},{j + 1}]: ");
//             //         matriz2[i, j] = Convert.ToInt32(Console.ReadLine());
//             //     }
//             // }

//             // for (int i = 0; i < 4; i++)
//             // {
//             //     for (int j = 0; j < 4; j++)
//             //     {
//             //         somaMatriz[i, j] = matriz1[i, j] + matriz2[i, j];
//             //     }
//             // }

//             // Console.WriteLine("A matriz resultante da soma é:");
//             // for (int i = 0; i < 4; i++)
//             // {
//             //     for (int j = 0; j < 4; j++)
//             //     {
//             //         Console.Write(somaMatriz[i, j] + "\t");
//             //     }
//             //     Console.WriteLine();
//             // }
            
// //             //Exercicio 6

// //             int[,] matriz1 = new int[4, 4];
// //             int[,] matriz2 = new int[4, 4];
// //             int[,] multiMatriz = new int[4, 4];

// //             Console.WriteLine("Digite os elementos da primeira matriz 4x4:");
// //             for (int i = 0; i < 4; i++)
// //             {
// //                 for (int j = 0; j < 4; j++)
// //                 {
// //                     Console.Write($"Elemento [{i + 1},{j + 1}]: ");
// //                     matriz1[i, j] = Convert.ToInt32(Console.ReadLine());
// //                 }
// //             }

// //             Console.WriteLine("Digite os elementos da segunda matriz 4x4:");
// //             for (int i = 0; i < 4; i++)
// //             {
// //                 for (int j = 0; j < 4; j++)
// //                 {
// //                     Console.Write($"Elemento [{i + 1},{j + 1}]: ");
// //                     matriz2[i, j] = Convert.ToInt32(Console.ReadLine());
// //                 }
// //             }

// //             for (int i = 0; i < 4; i++)
// //             {
// //                 for (int j = 0; j < 4; j++)
// //                 {
// //                     multiMatriz[i, j] = matriz1[i, j] * matriz2[i, j];
// //                 }
// //             }

// //             Console.WriteLine("A matriz resultante da soma é:");
// //             for (int i = 0; i < 4; i++)
// //             {
// //                 for (int j = 0; j < 4; j++)
// //                 {
// //                     Console.Write(multiMatriz[i, j] + "\t");
// //                 }
// //                 Console.WriteLine();
// //         }
// //     }
// // }
// // }
// namespace Aula_6;

// public class Matriz
// {
//     static void Main(string[] args)
//     {
        
//         int[,] matriz = new int[3, 3] {
//             {1, 2, 3},
//             {4, 5, 6},
//             {7, 8, 9}

//         };
//         int[,] transposta = new int[3, 3];

//         for  (int i = 0; i < matriz.GetLength(0); i++)
//         {
//             for (int j = 0; j < matriz.GetLength(1); j++)
//             {
//                 transposta [j, i] = matriz[i, j];
//             }
//         }
//         for (int i = 0; i < transposta.GetLength(0); i++)
// {
//     for (int j = 0; j < transposta.GetLength(1); j++)
//     {
//         Console.Write(transposta[i, j] + " ");
//     }
//     Console.WriteLine(); // Adicione esta linha para quebrar a linha
// }



//     }
// }