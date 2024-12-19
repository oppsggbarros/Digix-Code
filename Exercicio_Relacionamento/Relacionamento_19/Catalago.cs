using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_Relacionamento.Relacionamento_19
{
    public class CatalogoDeLivros
{
    private List<Livro> livros = new List<Livro>();

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public List<Livro> ConsultarLivros()
    {
        return livros;
    }
}
}