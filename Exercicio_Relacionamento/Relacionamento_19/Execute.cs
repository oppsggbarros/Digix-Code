using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_Relacionamento.Relacionamento_19
{
    public class Program
    {
        public static void Main(string[] args)
        {

            RedeDeBibliotecas rede = new RedeDeBibliotecas();
            Biblioteca biblioteca1 = new Biblioteca("Biblioteca Central");


            Funcionario funcionario1 = new Funcionario("João Silva", "12345678900", "Bibliotecário");
            biblioteca1.CadastrarFuncionario(funcionario1);


            Livro livro1 = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954, 5);
            biblioteca1.AdicionarLivro(livro1);
            Livro livro2 = new Livro("Harry Potter", "J.K Rolling", 1998, 10);
            biblioteca1.AdicionarLivro(livro2);


            rede.AdicionarBiblioteca(biblioteca1);


            Leitor leitor1 = new Leitor("Maria Oliveira", "98765432100");
            List<Livro> livrosDisponiveis = leitor1.ConsultarLivros(biblioteca1.Catalogo);


            Console.WriteLine("Livros disponíveis na biblioteca:");
            foreach (var livro in livrosDisponiveis)
            {
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.AnoPublicacao}, Exemplares: {livro.ExemplaresDisponiveis}");
            }
        }
    }
}