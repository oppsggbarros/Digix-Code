using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17_OO_Polimorfismo
{
    public class Assalariado : Empregado
    {
        public double Salario;

        
        public Assalariado(string nome, string sobrenome, string cpf, double salario)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            Salario = salario;
        }

        
        public override double Vencimento()
        {
            return Salario;
        }
    }
}