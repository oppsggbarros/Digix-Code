using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula19
{
    public class Universidade
    
    {
        public Professor professor;
        public Universidade(Professor professor)
        {
            this.professor = professor;
        }
        public void realizarAula()
        {
            Console.WriteLine("Aula em andamento");
            // professor.professor;
        }
    }
}