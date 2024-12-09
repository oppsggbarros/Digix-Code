using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17_OO_Polimorfismo
{
    public class Horista : Empregado
    {
        public double PrecoHora;
        public double HorasTrabalhadas;

        
        public Horista(string nome, string sobrenome, string cpf, double precoHora, double horasTrabalhadas)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            PrecoHora = precoHora;
            HorasTrabalhadas = horasTrabalhadas;
        }

        
        public override double Vencimento()
        {
            return PrecoHora * HorasTrabalhadas;
        }
    }
}