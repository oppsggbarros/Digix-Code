using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_13
{
    class Program
    {
        static void Maidasdn(string[] args)
        {
            Queue qt = new Queue();
            qt.Enqueue(1);
            qt.Enqueue(2);
            qt.Enqueue(3);
            

            foreach (Object obj in qt)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.WriteLine("Numero de Elementos na fila: " + qt.Count);
            
            Console.ReadKey();
            Console.Clear();

            qt.Dequeue();

            foreach (Object obj in qt)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.WriteLine("Numero de Elementos na fila: " + qt.Count);
            
            Console.ReadKey();
            Console.Clear();
            qt.Dequeue();
            foreach (Object obj in qt)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.WriteLine("Numero de Elementos na fila: " + qt.Count);
            
            Console.ReadKey();
            Console.Clear();

            qt.Dequeue();
            foreach (Object obj in qt)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.WriteLine("Numero de Elementos na fila: " + qt.Count);
            
            Console.ReadKey();
            
        }
    }
}