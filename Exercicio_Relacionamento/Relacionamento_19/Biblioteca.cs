using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_Relacionamento.Relacionamento_19
{
    public class Biblioteca
{
    public string Nome { get; set; }
    public CatalogoDeLivros Catalogo { get; private set; }
    private List<Funcionario> funcionarios = new List<Funcionario>();

    public Biblioteca(string nome)
    {
        Nome = nome;
        Catalogo = new CatalogoDeLivros();
    }

    public void CadastrarFuncionario(Funcionario funcionario)
    {
        funcionarios.Add(funcionario);
    }

    public void AdicionarLivro(Livro livro)
    {
        Catalogo.AdicionarLivro(livro);
    }
}
}