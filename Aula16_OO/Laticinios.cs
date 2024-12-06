using System;
namespace Aula_16_OO
{
    public class Laticinios
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
    
    public Laticinios()
    {
        Nome = "Leite";
        Preco =5.00;
        Quantidade = 20;

    }
    public Laticinios(string nome, double preco, int quantidade)
    {
        this.Nome = nome;
        this.Preco = preco;
        this.Quantidade = quantidade;
    }
    public double CalcularEstoque()
    {
        return Preco * Quantidade;
    }
}
}
