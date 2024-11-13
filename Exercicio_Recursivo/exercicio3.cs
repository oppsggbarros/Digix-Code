using System;
using System.Runtime.Intrinsics.Arm;

class Progra3
{

    static int Potenciaçao(int x, int n)
    {
    
        if (n == 0)
            return 1;
        else
            
            return x * Potenciaçao(x, n - 1);
    }

    static void Ma()
    {
        
        Console.Write("Digite um número ae: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite um outro número ae: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int potencia = Potenciaçao(n, x);
        Console.WriteLine(potencia);
        

        
    }
}
