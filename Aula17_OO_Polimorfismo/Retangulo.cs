using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula17_OOAbstrato
{
    public class Retangulo : Forma
    {
        public double Largura;
        public double Altura;

        public Retangulo (string nome, double altura, double largura) : base(nome)
        {
            this.Altura = altura;
            this.Largura = largura;
        }

        public override double CalcularArea()
        {
            return Largura * Altura;
        }

        public override double CalcularPerimetro()
        {
            return (2)*(Largura+Altura);
        }

        public override void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"Largura: {Largura}");
            System.Console.WriteLine($"Altura: {Altura}");
            System.Console.WriteLine($"Área: {CalcularArea()}");
            System.Console.WriteLine($"Perímetro: {CalcularPerimetro()}");
        }




    }
}