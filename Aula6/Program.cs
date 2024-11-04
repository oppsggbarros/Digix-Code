// // // namespace Aula_6;

// // // public class Matriz
// // // {
// // //     static void Main(string[] args)
// // //     {
        
// // //         int[,] matriz = new int[3, 3] {
// // //             {1, 2, 3},
// // //             {4, 5, 6},
// // //             {7, 8, 9}

// // //         };
// // //         int[,] transposta = new int[3, 3];

// // //         for  (int i = 0; i < matriz.GetLength(0); i++)
// // //         {
// // //             for (int j = 0; j < matriz.GetLength(1); j++)
// // //             {
// // //                 transposta [j, i] = matriz[i, j];
// // //             }
// // //         }
// // //         for (int i = 0; i <  transposta.GetLength(0); i++)
// // //         {
// // //             for (int j = 0; j < transposta.GetLength(1); j++){
// // //                 Console.Write(transposta[i, j] + " ");
// // //             }

// // //         }


// // //     }
// // // }


// // using System;

// // namespace Aula_7
// // {
// //     class Program
// //     {
// //         static void Main(string[] args)
// //         {
// //             // Matriz Tridimencional
// //             // Na tridiciomensional, 3 indices
// //             // 1º indice: Linha
// //             // 2º indice: Coluna
// //             // 3º indice: Profundidade

// //             int[,,] matriz3D = new int[2, 2, 2] {
// //                 {
// //                     {1, 2},
// //                     {3, 4}
// //                 },
// //                 {
// //                     {5, 6},
// //                     {7, 8}
// //                 }
// //             };
// //             int soma = 0;
// //             for (int i =  0; i < matriz3D.GetLength(0); i++)
// //             {
// //                 for (int j = 0; j < matriz3D.GetLength(1); j++)
// //                 {
// //                     for (int k = 0; k < matriz3D.GetLength(2); k++)
// //                     {
// //                         soma +=  matriz3D[i, j, k];


// //                     }
// //                 }
// //             }
// //             foreach (int item in  matriz3D)
// //             {
// //                 Console.Write(item + " ");
// //             }
// //         }
// //     }
// // }
// using System;

// namespace Aula_7
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int [] vetor = new int[10];
//             int i = 0;
//             Console.WriteLine("Digite 10 valores inteiros");
//             for (i = 0; i < 10; i++)
//             {
//                 vetor[i] = Convert.ToInt32(Console.ReadLine());
//             }
//             int media = 0;
//             for (i = 0; i < 10; i++)
//             {
//                 media += vetor[i];
                
//             }
//             media = media/10;
//             Console.WriteLine($"A média dos valores é {media}");

            
//         }
//     }
// }