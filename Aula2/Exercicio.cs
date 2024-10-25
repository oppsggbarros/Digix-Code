using System;
using System.Globalization;
namespace Exemplo
{
    internal class Progam2
    {
        static void Main (String[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa?");
            int quartos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com o seu preço: ");
            double preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre seu último nome, idade e altura: ");
            string informacoes = Console.ReadLine();
            string[] dados = informacoes.Split(' ');
            Console.Clear();
            if (dados.Length == 3)
            {
                string ultimonome = dados[0];
                int idade = int.Parse(dados[1]);
                double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);
                Console.WriteLine(nome);
                Console.WriteLine(quartos);
                Console.WriteLine(ultimonome);
                Console.WriteLine(idade);
                Console.WriteLine(altura);
                

            }
            

        }
    }
}