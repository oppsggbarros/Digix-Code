using System;
using System.Globalization;
namespace Exemplo
{
    internal class Progam
    {
        static void Main (String[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double preco3 = 53.234567;

            Console.WriteLine($"Produtos: \n{produto1}, cujo o preço é $ {preco1:f2}\n{produto2}, cujo o preço é $ {preco2:f2}\n\nRegistro: {idade} anos de idade, código {codigo} e genero: {genero}\n\nMedida com oito casas decimais: {preco3:f8}\nArredondado (três casas decimais): {preco3:f3}\nSeparador decimal invariant culture: {preco3.ToString("N3", CultureInfo.InvariantCulture)}");

        }
    }
}