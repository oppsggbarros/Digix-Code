
using System;
using System.Collections.Generic;



public enum TransactionType
{
    Deposit,
    Withdrawal
}


public class Bank
{
    public string Code { get; set; }
    public string Address { get; set; }
    private List<Account> accounts = new List<Account>();

    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }

    public List<Account> ListAccounts()
    {
        return accounts;
    }

    public Account GetAccountByNumber(string accountNumber)
    {
        return accounts.Find(acc => acc.Number == accountNumber);
    }
}


public class Customer
{
    public string Name { get; set; }
    public string Address { get; set; }
    public DateTime DOB { get; set; }
    public string CardNumber { get; set; }
    public string PIN { get; set; }

    public bool VerifyPassword(string pin)
    {
        return PIN == pin;
    }
}


public abstract class Account
{
    public string Number { get; set; }
    public decimal Balance { get; protected set; }
    public Customer Owner { get; set; }
    private List<ATMTransaction> transactionHistory = new List<ATMTransaction>();

    public abstract void Withdraw(decimal amount);

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be greater than zero.");

        Balance += amount;
        transactionHistory.Add(new ATMTransaction
        {
            TransactionId = Guid.NewGuid().ToString(),
            Date = DateTime.Now,
            Type = TransactionType.Deposit,
            Amount = amount,
            PostBalance = Balance
        });
    }

    public List<ATMTransaction> GetTransactionHistory()
    {
        return transactionHistory;
    }
}


public class CurrentAccount : Account
{
    public override void Withdraw(decimal amount)
    {
        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds.");

        Balance -= amount;
        
    }
}


public class SavingAccount : Account
{
    public override void Withdraw(decimal amount)
    {
        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds.");

        Balance -= amount;
    }
}


public class ATM
{
    public string Location { get; set; }
    public Bank ManagedBy { get; set; }

    public void Identify()
    {
        Console.WriteLine("ATM Identified.");
    }
}


public class ATMTransaction
{
    public string TransactionId { get; set; }
    public DateTime Date { get; set; }
    public TransactionType Type { get; set; }
    public decimal Amount { get; set; }
    public decimal PostBalance { get; set; }
    
}
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            string loginverificarion;
            string password;
            System.Console.WriteLine("Bem vindo ao banco\nCrie sua conta"); 
            // int op = Convert.ToInt32(Console.ReadLine());
            Customer customer = new Customer();
            System.Console.WriteLine("Digite seu nome:"); customer.Name = Convert.ToString(Console.ReadLine());
            customer.Address = Convert.ToString(Console.ReadLine());
            customer.DOB = DateTime.Now;
            customer.CardNumber = Convert.ToString(Console.ReadLine());
            customer.PIN = Convert.ToString(Console.ReadLine());
            System.Console.WriteLine("Conta criada. Pressione qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
            System.Console.WriteLine("Login: ");loginverificarion = Convert.ToString(Console.ReadLine());
            System.Console.WriteLine("Senha: "); password = Convert.ToString(Console.ReadLine());
            if (customer.Name == loginverificarion && customer.PIN ==  password)
            {
                System.Console.WriteLine("Login realizado com sucesso");
            }
            else
            {
                System.Console.WriteLine("Login inválido");
                return;
            }
            System.Console.WriteLine("Bem vindo ao banco\nSelecione conta que deseja:"); int op = Convert.ToInt32(Console.ReadLine());
        }
            
        catch
        {
            System.Console.WriteLine("Erro ao criar conta");

        }
        
        }
        
       

        
        // Bank bank = new Bank();

        
        // CurrentAccount currentAccount = new CurrentAccount();
        // SavingAccount savingAccount = new SavingAccount();

        
        // bank.AddAccount(currentAccount);
        // bank.AddAccount(savingAccount);

        
        // try
        // {
        //     currentAccount.Deposit(500);
        //     currentAccount.Deposit(500);
        //     currentAccount.Deposit(500);
        //     currentAccount.Deposit(500);
            
            
        //     savingAccount.Deposit(1000);
        //     savingAccount.Withdraw(500);

            
        //     Console.WriteLine("Current Account Transactions:");
        //     foreach (var transaction in currentAccount.GetTransactionHistory())
        //     { 
        //         Console.WriteLine($"\t{transaction.Type}: {transaction.Amount}, Balance: {transaction.PostBalance}");
                
        //     }

        //     Console.WriteLine("Saving Account Transactions:");
        //     foreach (var transaction in savingAccount.GetTransactionHistory())
        //     {
        //         Console.WriteLine($"\t{transaction.Type}: {transaction.Amount}, Balance: {transaction.PostBalance}");
        //     }
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine($"Error: {ex.Message}");
        // }
    }
