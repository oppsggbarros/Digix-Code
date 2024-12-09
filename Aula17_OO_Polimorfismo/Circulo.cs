using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula17_OOAbstrato
{
    public class Circulo : Forma
    {
        public double Raio;

        public Circulo(string nome, double raio) : base(nome)
        {
            this.Raio = raio;
        }

        public override double CalcularArea()
        
        {
            return Math.PI * Math.Pow(Raio,2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

        public override void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"Raio: {Raio}");
            System.Console.WriteLine($"Area: {CalcularArea()}");
            System.Console.WriteLine($"Perimetro: {CalcularPerimetro()}");
        }

    }
}