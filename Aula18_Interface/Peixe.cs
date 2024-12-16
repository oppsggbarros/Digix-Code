using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula18_Interface
{
    public class Peixe : Animal, AnimalDeEstimacao
    {
        private string nome;

        public Peixe()
        {
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public void Brinca()
        {
            Console.WriteLine("O peixe está brincando");
        }

        public void Come()
        {
            Console.WriteLine("O peixe está comendo");
        }
    }
}