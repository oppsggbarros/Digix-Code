using System;
using System.Collections;

namespace Aula_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue fila1 = new Queue();
            fila1.Enqueue(10);
            fila1.Enqueue(20);

            Queue fila2 = new Queue();
            fila2.Enqueue(30);
            fila2.Enqueue(40);

            
            InserirElementosNaFila(fila1, fila2);

            
            foreach (Object obj in fila1)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.WriteLine("Número de Elementos na fila: " + fila1.Count);

            Console.ReadKey();
        }

        static void InserirElementosNaFila(Queue filaAtual, Queue filaParaInserir)
        {
            foreach (Object obj in filaParaInserir)
            {
                filaAtual.Enqueue(obj);
            }
        }
    }
}