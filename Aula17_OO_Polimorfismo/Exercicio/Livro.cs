using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17_OO_Polimorfismo.Exercicio
{
    public class Livro : Produto
    {
        
        private string autor;
        private long isbn;

        
        public Livro(int codigo, double preco, string autor, long isbn) 
            : base(codigo, preco)
        {
            this.autor = autor;
            this.isbn = isbn;
        }

        
        public void setAutor(string autor)
        {
            this.autor = autor;
        }

        public void setlsbn(long isbn)
        {
            this.isbn = isbn;
        }

        public string getAutor()
        {
            return this.autor;
        }

        public long getIsbn()
        {
            return this.isbn;
        }
    }
}