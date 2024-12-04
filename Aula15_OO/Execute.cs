using System;
using Padaria;
namespace Padaria
{
    public class Execute
    {
        public static void Main(string[] args)
        {
            Padaria padaria = new Padaria();
            padaria.Nome = "Arroz";
            padaria.Bebidas = "Café";
            padaria.Preco = 10.0;
            padaria.Doces = "Bolo";
            padaria.DataValidade = DateTime.Now.AddDays(3);
            Console.WriteLine(padaria.encomenda());

            List<(string Nome, double Preco)> ListaCompras = new List<(string Nome, double Preco)>
            {
                ("Arroz", 10.0),
                ("Café", 5.0),
                ("Bolo", 15.0),
                
            };
            double total = padaria.Cesta(ListaCompras);
            Console.WriteLine(total);
            
            
            
        }
    }
}