using System;
namespace Aula_16_OO
{
    public class Petiscos
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
    
    public Petiscos()
    {
        Nome = "Coxinha";
        Preco = 0;
        Quantidade = 10;

    }
    public Petiscos(string nome, double preco, int quantidade)
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
