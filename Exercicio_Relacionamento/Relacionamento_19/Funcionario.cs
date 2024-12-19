using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_Relacionamento.Relacionamento_19
{
    public class Funcionario : Usuario
    {
        public string Cargo { get; set; }

        public Funcionario(string nome, string cpf, string cargo) : base(nome, cpf)
        {
            Cargo = cargo;
        }

        public void AtualizarCatalogo(CatalogoDeLivros catalogo, Livro livro)
        {
            catalogo.AdicionarLivro(livro);
        }
    }
}