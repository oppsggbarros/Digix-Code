using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Aula_13
{
    class Pilha
    {
        static void Main(string[] args)
        {
            Stack pilha = new Stack();
            pilha.Push(1);
            pilha.Push(5);
            pilha.Push(3);

            foreach (Object obj in pilha)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.WriteLine("Numero de Elementos na fila: " + pilha.Count);
            
            Console.ReadKey();
            Console.Clear();

            pilha.Pop();

            foreach (Object obj in pilha)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.WriteLine("Numero de Elementos na fila: " + pilha.Count);
            
            Console.ReadKey();
            Console.Clear();
            pilha.Pop();
            foreach (Object obj in pilha)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.WriteLine("Numero de Elementos na fila: " + pilha.Count);
            
            Console.ReadKey();
            Console.Clear();

            pilha.Pop();
            foreach (Object obj in pilha)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.WriteLine("Numero de Elementos na fila: " + pilha.Count);
            
            Console.ReadKey();
        }
    }
}