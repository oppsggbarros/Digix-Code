using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17_OO_Polimorfismo.Exercicio
{
    public class CompactDisc : Produto
    {
        private string artista;
        private string gravadora;
        public CompactDisc(int codigo, double preco, string artista, string gravadora) : base(codigo, preco)
        {
            this.artista = artista;
            this.gravadora = gravadora;

        }
        public void setArtista(string artista)
        {
            this.artista = artista;
        }
        public void setGravadora(string gravadora)
        {
            this.gravadora = gravadora;
        }

        public string getArtista()
        {
            return this.artista;
        }

        public string getGravadora()
        {
            return this.gravadora;
        }
    }
}