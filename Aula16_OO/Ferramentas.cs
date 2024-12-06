using System;
namespace Aula_16_OO
{
    public class Ferramentas
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
    
    public Ferramentas()
    {
        Nome = "Martelo";
        Preco = 80.00;
        Quantidade = 1;

    }
    public Ferramentas(string nome, double preco, int quantidade)
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
