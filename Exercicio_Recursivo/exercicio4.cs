using System;

class Program4
{
    
    static int CalcularMDC(int x, int n)
    {
        
        if (n == 0)
            return x;
        else
            
            return CalcularMDC(n, x % n);
    }

    static void ain()
    {
        
        Console.Write("Digite o primeiro número inteiro: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número inteiro: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int mdc = CalcularMDC(x, n);
        Console.WriteLine(mdc);
    }
}
