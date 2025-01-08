using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe_Selada
{
    public class Coordenador : Funcionario
    {
        public override void Salario(int salario)
        {
            Console.WriteLine("Salario Base:" + salario * 1.2);
        }
        public sealed override void Trabalhar()
        {
            Console.WriteLine("Coordenando...");
        }
    }
}