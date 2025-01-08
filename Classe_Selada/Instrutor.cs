using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe_Selada
{
    public class Instrutor : Coordenador
    {
        public override void Salario(int salario)
        {
            Console.WriteLine("Salario base:" + salario * 1.3);
        }
        // public override void Trabalhar()
        // {
        //     Console.WriteLine("Instruindo");
        // }
    }
}