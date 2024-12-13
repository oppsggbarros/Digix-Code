using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula18_Encapsulamento
{
    public class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        // public Produto()
        // {

        // }
        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }
        // public string GetNome()
        // {
        //     return _nome;
        // }
        // public void setNome(string nome)
        // {
        //     _nome = nome;
        // }
        // public double GetPreco()
        // {
        //     return _preco;
        // }
        // public void setPreco(double preco)
        // {
        //     _preco = preco;
        // }
        // public int GetQuantidade()
        // {
        //     return _quantidade;

        // }
        // public void setQuantidade(int quantidade)
        // {
        //     _quantidade = quantidade;
        // }
        // public void AdicionarProdutos(int quantidade)
        // {
        //     _quantidade += quantidade;
        // }
        // public void RemoverProdutos(int quantidade)
        // {
        //     _quantidade -= quantidade;
        // }
        // public double CalcularPrecoTotal()
        // {
        //     return _preco * _quantidade;
        // }
        // public override string ToString()
        // {
        //     return _nome + ", $ " + _preco.ToString("F2") + 
        //     ", " + CalcularPrecoTotal().ToString("F2");
        // }
        
        
            public string Nome
            {
                get 
                {
                    return _nome;
                }
                set
                {
                    if (value != null && value.Length > 0)
                    {
                        _nome = value;
                    }
                    
                }
            }
            public double Preco
            {
                get
                {
                    return _preco;
                }
                set
                {
                    if (value > 0)
                    {
                        _preco = value;
                    }
                }
            }
            public int Quantidade
            {
                get
                {
                    return _quantidade;
                }
                set
                {
                    if (value >= 0)
                    {
                        _quantidade = value;
                    }
                }
            }
        }
        }
    
