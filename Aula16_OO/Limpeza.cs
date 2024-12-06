using System;
namespace Aula_16_OO
{
    public class Limpeza
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
    
    public Limpeza()
    {
        Nome = "Coxinha";
        Preco = 0;
        Quantidade = 10;

    }
    public Limpeza(string nome, double preco, int quantidade)
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
