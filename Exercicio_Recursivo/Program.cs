using System;

class Program
{

    static int Soma(int n)
    {
    
        if (n == 1)
            return 1;
        else
            
            return n + Soma(n - 1);
    }

    static void M()
    {
        
        Console.Write("Digite um número ae: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int soma = Soma(n);
        Console.WriteLine(soma);
        

        
    }
}
