using System;
using System.Linq;
using System.Collections.Generic;
namespace exercicio
{
    internal class Produtos
    {
        static void Main (String[] args)
        {
            int a = 1;
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
                    a++;
                }
                
                
                
            }
            
            int maiorvalor = numeros.Max();
            int menorvalor = numeros.Min();
            Console.WriteLine($"Maior: {maiorvalor}");
            Console.WriteLine($"Menor: {menorvalor}");  
            
        }
    }
}