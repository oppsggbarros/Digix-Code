using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula25_Struct
{
    // public class PessoaStruct
    // {
    //     public string Nome { get; set; }
    //     public int Idade { get; set; }
    //     public PessoaStruct(string nome, int idade)
    //     {
    //         Nome = nome;
    //         Idade = idade;

    //     }
    //     public override string ToString()
    //     {
    //         return $"Pessoa: {Nome}, Idade: {Idade}";
    //     }

    // }
    public class ContaBancariaStruct
    {
        public string Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }
        
        public ContaBancariaStruct(string numero, string titular, decimal saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;

        }
        public void Deposito(decimal valor)
        {
            Saldo += valor;
        }
        public void Saque(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saque não realizado, valor insuficiente");
            }
        }
        public void AlterarSaldo(decimal valor)
        {
            Saldo =+ valor;
            System.Console.WriteLine("Saldo Alterado com sucesso");
        }
        public override string ToString()
        {
            return $"Conta: {Numero}, Titular: {Titular}, Saldo: {Saldo}";
        }
    }
    public class ContaBancariaClass
    {
        public string Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }
        
        public ContaBancariaClass(string numero, string titular, decimal saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;

        }
        public void Deposito(decimal valor)
        {
            Saldo += valor;
        }
        public void Saque(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saque não realizado, valor insuficiente");
            }
        }
        public override string ToString()
        {
            return $"Conta: {Numero}, Titular: {Titular}, Saldo: {Saldo}";
        }
    }
}