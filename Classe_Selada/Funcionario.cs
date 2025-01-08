using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe_Selada
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public virtual void Salario(int salario)
        {
            Console.WriteLine("Salario base: R$" + salario);
        }
        public virtual void Trabalhar()
        {
            Console.WriteLine("O funcionário está trabalhando");
        }
        
    }
}