using System;

class Progra2
{

    static int Produto(int n)
    {
    
        if (n == 1)
            return 1;
        else
            
            return n * Produto(n - 1);
    }

    static void Mai()
    {
        
        Console.Write("Digite um número ae: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int produto = Produto(n);
        Console.WriteLine(produto);
        

        
    }
}
