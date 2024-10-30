using System;
using System.Globalization;
namespace Exemplo
{
    internal class DDD
    {
        static void Ddd (String[] args)
        {
            Console.Write("Digite o DDD: ");
            int ddd = Convert.ToInt32(Console.ReadLine());

            switch (ddd)
            {
                case 41:
                case 42:
                case 43:
                case 44:
                case 45:
                case 46:
                    Console.WriteLine("Paraná");
                    break;

                case 51:
                case 53:
                case 54:
                case 55:
                    Console.WriteLine("Rio Grande do Sul");
                    break;

                case 61:
                    Console.WriteLine("Brasília");
                    break;

                case 62:
                case 64:
                    Console.WriteLine("Goiás");
                    break;

                case 65:
                case 66:
                    Console.WriteLine("Mato Grosso");
                    break;

                case 67:
                    Console.WriteLine("Mato Grosso do Sul");
                    break;

                default:
                    Console.WriteLine("DDD não cadastrado.");
                    break;
            }
        }
    }
}