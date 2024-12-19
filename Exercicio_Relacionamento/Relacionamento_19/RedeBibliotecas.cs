using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_Relacionamento.Relacionamento_19
{
    public class RedeDeBibliotecas
    {
        private List<Biblioteca> bibliotecas = new List<Biblioteca>();

        public void AdicionarBiblioteca(Biblioteca biblioteca)
        {
            bibliotecas.Add(biblioteca);
        }

        public void RemoverBiblioteca(Biblioteca biblioteca)
        {
            bibliotecas.Remove(biblioteca);
        }
    }
}