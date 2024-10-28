using System;
namespace Exemplo
{
    internal class For_While
    {
        static void c()
        {
        
            // while (i <=10)
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }
            // for (int j = 1; j <= 10; j++)
            // {
            //     Console.WriteLine(j);
            // }
            Console.WriteLine("Digite um numero para ser multiplicado");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num*i}");
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Digite um numero para ser multiplicado");
            int number = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();
            int j = 0;
            while (j <= 10)
            {
                Console.WriteLine($"{number} x {j} = {number*j}");
                j++;
            }



        }
    }
}