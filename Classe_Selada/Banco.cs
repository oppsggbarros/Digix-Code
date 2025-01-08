using System;

namespace Banco
{
    public class Account
    {
       
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }
    

        
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("O valor do depósito deve ser positivo.");
            }
            Balance += amount;
        }

        
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("O valor do saque deve ser positivo.");
            }
            if (amount > WithdrawLimit)
            {
                throw new InvalidOperationException("Erro: O valor excede o limite de saque.");
            }
            if (amount > Balance)
            {
                throw new InvalidOperationException("Erro: Saldo insuficiente.");
            }
            Balance -= amount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Console.WriteLine("Entre com os dados da conta:");
                Console.Write("Número: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Titular: ");
                string holder = Console.ReadLine();
                Console.Write("Saldo inicial: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Limite de saque: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                
                Account account = new Account(number, holder, balance, withdrawLimit);

                
                Console.Write("\nDigite um valor para sacar: ");
                double amount = double.Parse(Console.ReadLine());

                account.Withdraw(amount);

                Console.WriteLine($"Saque realizado com sucesso! Novo saldo: {account.Balance:F2}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }
}
