using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_Relacionamento.Relacionamento_19
{
    public class Leitor : Usuario
    {
        public Leitor(string nome, string cpf) : base(nome, cpf) { }

        public List<Livro> ConsultarLivros(CatalogoDeLivros catalogo)
        {
            return catalogo.ConsultarLivros();
        }
    }
}