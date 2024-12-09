using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17_OO_Polimorfismo.Exercicio
{
    public abstract class Produto
    {
        private int codigo;
        private double preco;

        protected Produto(int codigo , double preco)
        {
            this.codigo = codigo;
            this.preco = preco;
        }
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public void SetPreco(double preco)
        {
            this.preco = preco;
        }
        public int getCodigo()
        {
            return this.codigo;
        }

        public double getPreco()
        {
            return this.preco;
        }

        public void atualizaPreco(double preco)
        {
            this.preco = preco;
        }
    }
}