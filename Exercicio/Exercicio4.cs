using System;
using System.Linq;
using System.Collections.Generic;
namespace exercicio
{
    internal class NUmero
    {
        static void numerossd (String[] args)
        {
            
            List<int> numeros = new List<int>();
            while (true)
            {
                Console.WriteLine("Informe um numero: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == -1)
                {
                    break;
                }
                else
                {
                    numeros.Add(num);
                    
                }                
            }
            
            int maiorvalor = numeros.Max();
            int menorvalor = numeros.Min();
            Console.WriteLine($"Maior: {maiorvalor}");
            Console.WriteLine($"Menor: {menorvalor}");  
            
        }
    }
}