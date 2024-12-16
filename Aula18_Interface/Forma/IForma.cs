using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula18_Interface
{
    public interface IForma
    {
        double CalcularArea();
        double CalcularPerimetro();
        void ExibirInformações()
        {
            Console.WriteLine("Área : " + CalcularArea());
            Console.WriteLine("Perímetro : " + CalcularPerimetro());
        }
    }
}