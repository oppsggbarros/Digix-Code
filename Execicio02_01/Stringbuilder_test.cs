using System;
using System.Text;

namespace Exercicio02_01
{
    public class ConcatenaString
    {
        public static void Main(string[] args)
        {
            // Teste com o operador '+'
            string strFinal = "";
            var tStart = DateTime.Now.Ticks; // Obtém o tempo inicial em ticks
            for (int i = 0; i < 100000; i++)
            {
                strFinal += "a";
            }
            var tEnd = DateTime.Now.Ticks; // Obtém o tempo final em ticks
            var tResult = (tEnd - tStart) / TimeSpan.TicksPerMillisecond;
            Console.WriteLine($"Tempo de Execução com operador '+' = {tResult} ms");

            // Teste com StringBuilder
            StringBuilder strBuilder = new StringBuilder();
            tStart = DateTime.Now.Ticks;
            for (int i = 0; i < 100000; i++)
            {
                strBuilder.Append("a");
            }
            tEnd = DateTime.Now.Ticks;
            tResult = (tEnd - tStart) / TimeSpan.TicksPerMillisecond;
            Console.WriteLine($"Tempo de Execução com StringBuilder = {tResult} ms");
        }
    }
}
