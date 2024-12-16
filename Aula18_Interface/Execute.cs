using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula18_Interface
{
    public class Execute
    {
        static void Main(string[] args)
        {
            
            Formiga formiga = new Formiga();
            formiga.Come();

            
            Cachorro cachorro = new Cachorro("Rex");
            Console.WriteLine("Nome do cachorro: " + cachorro.GetNome());
            cachorro.Come();
            cachorro.Brinca();

            
            Peixe peixe = new Peixe();
            peixe.SetNome("Nemo");
            Console.WriteLine("Nome do peixe: " + peixe.GetNome());
            peixe.Come();
            peixe.Brinca();
        }
    }
}
