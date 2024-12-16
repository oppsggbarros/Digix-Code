// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula18_Interface
// {
//     public class CartaoCredito : IPagamento, Anuidade
//     {
//         public string NumeroCartao { get; set; }
//         public DateTime DataVencimento { get; set; }

//         public CartaoCredito(string numeroCartao)
//         {
//             NumeroCartao = numeroCartao;
//         }
//         public CartaoCredito(string numeroCartao, DateTime dataVencimento)
//         {
//             NumeroCartao = numeroCartao;
//             DataVencimento = dataVencimento;
            
//         }
//         public void RealizarPagamento(double valor)
//         {
//             Console.WriteLine($"Pagamento realizado com cartão de crédito {NumeroCartao} no valor de R${valor}");
//         }
//         public void ExibirComprovante()
//         {
//             Console.WriteLine($"Comprovante de pagamento realizado com cartão de crédito {NumeroCartao}");
//         }
//         public DateTime CalcularDataVencimento()
//         {
//             return DateTime.Now.AddYears(1);
//         }

//     }
// }