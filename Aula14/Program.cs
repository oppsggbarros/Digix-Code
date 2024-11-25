// using System;
// namespace Aula_14
// {
//     public class ListaEncadeadaDelagate
//     {
//         static delegate void FuncaoDelagate(int valor);

//         string x = null;
        
//         static FuncaoDelagate? inicio = null;
        
//         static FuncaoDelagate CriarNo(int valor, FuncaoDelagate? proximo = null)

//         {
//             return v => 
//             { 
//                 Console.WriteLine(valor); 
//                 proximo?.Invoke(v); 
//             };
//         }
//     }
// }