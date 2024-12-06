using System;
namespace Aula_16_OO
{
    public class Carnes
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
    
    
    public Carnes(string nome, double preco, int quantidade)
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
