using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula18_Interface
{
    public class Formiga : Animal
    {
        public Formiga()
        {
        }

        public void Come()
        {
            Console.WriteLine("A formiga está comendo");
        }
    }
}