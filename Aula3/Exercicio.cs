using System;

namespace Exemplo
{
    internal class Exercicio
    {
        static void Main (String[] args)
        {
            Console.WriteLine("Insira o valor desejado: "); 
            int valor = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Selecione um tipo de Investimento\n1-Poupança\n2-Renda Fixa\n3-Ações");
            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Digite o número de anos do investimento: ");
            int anos = Convert.ToInt32(Console.ReadLine());

            decimal taxaAnual = 0;

            switch (opcao)
            {
                case 1:
                    taxaAnual = 0.03m;
                    break;
                case 2:
                    taxaAnual = 0.05m;
                    break;
                case 3:
                    taxaAnual = 0.10m;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    return;
            }

            
            if (opcao == 3)
            {
                decimal montanteAtual = valor;
                for (int ano = 1; ano <= anos; ano++)
                {
                    montanteAtual += montanteAtual * taxaAnual; 
                    Console.WriteLine($"Ano {ano}: R$ {montanteAtual:F2}");

                    // Verifica se há perda de 5% (simulando a chance de perda em cada ano)
                    Random random = new Random();
                    int chance = random.Next(1, 101); 

                    if (chance <= 5)
                    {
                        montanteAtual *= 0.95m; 
                        Console.WriteLine($"Atenção: Houve uma perda de 5% no ano {ano}. Novo montante: R$ {montanteAtual:F2}");
                    }
                }
                Console.WriteLine($"\nMontante final após {anos} anos: R$ {montanteAtual:F2}");
            }
            else
            {
                decimal montanteFinal = valor * (1 + taxaAnual * anos);
                Console.WriteLine($"\nApós {anos} anos, o montante final será: R$ {montanteFinal:F2}");
            }
        }
    }
}
