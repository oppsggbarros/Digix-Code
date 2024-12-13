using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula18_Encapsulamento
{
    public class ExecutarBanco
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Bem-vindo ao Sistema de Conta Bancária!");

               
                Console.Write("Digite o número da conta: ");
                int numeroConta = Convert.ToInt32(Console.ReadLine());

                
                Console.Write("Digite o nome do titular da conta: ");
                string nomeTitularConta = Console.ReadLine();

                
                ContaBancaria conta = new ContaBancaria(numeroConta, nomeTitularConta);

                
                Console.Write("Digite o valor do depósito inicial: ");
                double depositoInicial = Convert.ToDouble(Console.ReadLine());
                conta.Depositar(depositoInicial);

                
                while (true)
                {
                    Console.WriteLine("\nEscolha uma ação:");
                    Console.WriteLine("1. Depositar");
                    Console.WriteLine("2. Sacar");
                    Console.WriteLine("3. Exibir detalhes da conta");
                    Console.WriteLine("4. Sair");
                    Console.Write("Digite sua escolha: ");
                    int escolha = Convert.ToInt32(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            Console.Write("Digite o valor para depositar: ");
                            double valorDeposito = Convert.ToDouble(Console.ReadLine());
                            conta.Depositar(valorDeposito);
                            break;
                        case 2:
                            Console.Write("Digite o valor para sacar: ");
                            double valorSaque = Convert.ToDouble(Console.ReadLine()); 
                            conta.Sacar(valorSaque);
                            break;
                        case 3:
                            conta.ExibirDetalhesConta();
                            break;
                        case 4:
                            Console.WriteLine("Obrigado por usar o banco!");
                            return;
                        default:
                            Console.WriteLine("Escolha inválida.");
                            break;
                    }
                }
            }
        }
    }
}
