using System;

namespace Aula17_OO_Polimorfismo.Exercicio
{
    public class Executar
    {
        public static void Main(string[] args) {
            
            CompactDisc cd = new CompactDisc(1, 15.99, "Michael Jackson", "Sony Music");
            cd.SetPreco(15.99);


            Livro book = new Livro(1, 19.99, "J.K. Rowling", 9780747532693);
            book.SetPreco(19.99);

           
            Console.WriteLine("Compact Disc:");
            Console.WriteLine("Artista: " + cd.getArtista());
            Console.WriteLine("Gravadora: " + cd.getGravadora());
            Console.WriteLine("Preco: " + cd.getPreco());

            
            Console.WriteLine("\nLivro:");
            Console.WriteLine("Autor: " + book.getAutor());
            Console.WriteLine("ISBN: " + book.getIsbn());
            Console.WriteLine("Preco: " + book.getPreco());
        }
    }
}