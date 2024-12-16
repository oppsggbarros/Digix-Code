using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula18_Interface
{
    public class Circulo : IForma
    {
        public double Raio { get; set; }
        public Circulo(double raio)
        {
            Raio = raio;
        }
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
        public void ExibirInformações()
        {
            System.Console.WriteLine("Circulo");
            System.Console.WriteLine("Raio: " + Raio);
        }
        
    }
}