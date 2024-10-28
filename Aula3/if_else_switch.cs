using System;

namespace Exemplo
{
    internal class Switch
    {
        static void Teste()
        {
            Console.WriteLine("Digite uma idade:");
            int num = Convert.ToInt32(Console.ReadLine());

            string categoria = num switch
            {
                >= 18 and <= 50 => "Adulto",
                >= 51 and <= 100 => "Idoso",
                >= 0 and <= 17 => "Jovem",
                _ => "Idade inválida"
            };

            Console.WriteLine(categoria);
        }
    }
}
