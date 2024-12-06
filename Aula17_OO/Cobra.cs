using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17_OO
{
    public class Cobra : Animal
    {
        public Boolean venenosa;
        
        public Cobra(Boolean estaVivo, Boolean venenosa) : base(estaVivo) // O base é utilizado para chamar o construtor da classe pai
        {
            // base é utilizado para chamar o construtor da classe pai
            this.venenosa = venenosa;
        }
        public override Boolean setVenenosa()
        {
            return true;
        }
        public void Alimento()
        {
            Console.WriteLine("A cobra se alimenta de ratos");
        }

    }
}