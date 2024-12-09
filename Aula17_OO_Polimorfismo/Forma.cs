using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula17_OOAbstrato
{
    public abstract class Forma
    {
        public string Nome;

        public Forma(string nome)
        {
            this.Nome = nome;
        }

        // Metodo abstrato não possui "Corpo" e DEVE ser implementado na classe filho
        public abstract double CalcularArea();

        public abstract double CalcularPerimetro();

        public virtual void ImprimirDados()
        {
            System.Console.WriteLine("Nome: "+ Nome);
            System.Console.WriteLine("Area: "+ CalcularArea());
            System.Console.WriteLine("Perimetro: "+CalcularPerimetro());
        }

        // Outra Forma de Imprimir
        // public override void Imprimir()
        // {
        //     base.ImprimirDados();
        //     System.Console.WriteLine("Area: "+ CalcularArea());
        //     System.Console.WriteLine("Perimetro: "+CalcularPerimetro());
        // }
    
    
    }
}