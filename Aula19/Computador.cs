using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula19
{
    public class Computador
    {
        public Processador processador;
        public Computador()
        {
            processador = new Processador();
        }
        void iniciar()
        {
            System.Console.WriteLine("Processando...");
            
        }
    }
}