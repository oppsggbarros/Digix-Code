using System;
using System.Globalization;
namespace Exemplo
{
    internal class Progam2
    {
        static void Senha (String[] args)
        {
            string senha = "Digix";
            string senhaaa = Convert.ToString(Console.ReadLine());
            if (senhaaa == senha)
            {
                Console.WriteLine("Acesso permitido");
            }
            else
            {
                Console.WriteLine("Acesso negado");
            }
        }
    }
}