using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17_OO
{
    public class Secretaria : Funcionario
    {
        public string Ramal;
        public Secretaria(string nome, string cpf, double salario, string ramal) : base(nome, cpf, salario)
        {
            this.Ramal = ramal;

        }
        public override double GetBonificacao()
        {
            return Salario * 0.05;
        }
        public override void ImprimirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Salario: {Salario}");
            Console.WriteLine($"Ramal: {Ramal}");
            System.Console.WriteLine($"Bonificação: {GetBonificacao()}");
        }
        public void AtenderTelefone()
        {
            Console.WriteLine($"Atendendo o telefone {Ramal}");
        }
    }
}