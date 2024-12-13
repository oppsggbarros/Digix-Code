using System;

public class ContaBancaria
{
    private int numeroConta;
    private string nomeTitular;
    private double saldo;

    
    public ContaBancaria(int numeroConta, string nomeTitular, double saldoInicial = 0)
    {
        this.numeroConta = numeroConta;
        this.nomeTitular = nomeTitular;
        this.saldo = saldoInicial;
    }

    
    public void Depositar(double valor)
    {
        if (valor >= 0)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de R${valor:F2} realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Valor de depósito inválido.");
        }
    }

    
    public void Sacar(double valor)
    {
        if (valor > 0 && valor <= saldo)
        {
            saldo -= valor+5;
             
            Console.WriteLine($"Saque de R${valor:F2} realizado com sucesso.");
        }
        else if (valor > saldo)
        {
            Console.WriteLine("Saldo insuficiente.");
        }
        else
        {
            Console.WriteLine("Valor de saque inválido.");
        }
    }

    
    public void ExibirDetalhesConta()
    {
        Console.WriteLine($"Número da Conta: {numeroConta}");
        Console.WriteLine($"Nome do Titular: {nomeTitular}");
        Console.WriteLine($"Saldo Atual: R${saldo:F2}");
    }
}
