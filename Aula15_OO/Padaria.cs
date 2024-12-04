using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Padaria
{
    public class Padaria
    {
        public string Nome;
        public double Preco;
        public string Bebidas;
        public string Doces;
        public DateTime DataValidade;

        public string encomenda()
        {
            return $"Nome: {Nome}\nPreco: {Preco}";
        }
        public double Cesta(List<(string Nome, double Preco)> itens)
        {
            double total = 0;
            foreach (var item in itens)
            {
                System.Console.WriteLine($"Item: {item.Nome}, Preco: {item.Preco}");
                total += item.Preco;
            }
            return total;
        }
    }
}
