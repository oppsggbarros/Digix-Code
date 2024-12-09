using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17_OO_Polimorfismo
{
    public class Comissionado : Empregado
    {
        public double TotalVenda;
        public double TaxaComissao;

        
        public Comissionado(string nome, string sobrenome, string cpf, double totalVenda, double taxaComissao)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            TotalVenda = totalVenda;
            TaxaComissao = taxaComissao;
        }

        
        public override double Vencimento()
        {
            return TotalVenda * TaxaComissao;
        }
    }
}