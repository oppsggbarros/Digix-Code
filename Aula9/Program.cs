using System;

namespace Aula_9
{
    class Program
    {
        static int ParOuImpar(int num)
        {
            if (num % 2 == 0)
            {
                return 0;

            }
            else
            {
                return 1;
                
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero ae: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int resultado = ParOuImpar(num);
            if (resultado == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
        }
    }
}