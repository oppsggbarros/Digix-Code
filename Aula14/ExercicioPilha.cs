using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_13
{
    public class Pilha
    {
        static int[] pilha = new int[10];

        static int topo = 0; // topo da pilha

        // Adiciona um elemento na pilha, Push
        public static void Adicionar(int valor)
        {
            if (topo < pilha.Length)
            {
                pilha[topo] = valor;
                topo++; // Incrementa o topo
            }
            else
            {
                Console.WriteLine("Pilha cheia!");
            }
        }

        // Remove um elemento da pilha, Pop
        static void Remover()
        {
            if (topo > 0)
            {
                topo--; // Decrementa o topo
                pilha[topo] = 0;
            }
            else
            {
                Console.WriteLine("Pilha vazia!");
            }
        }

        // Listar os elementos da pilha do topo para a base
        public static void Listar()
        {
            for (int i = topo - 1; i >= 0; i--)
            {
                Console.WriteLine(pilha[i]);
            }
        }
        public static void Topo()
        {
            int i = topo - 1;
            System.Console.WriteLine(pilha[i]);
        }
        // Reverte a pilha
        public static void Reverter()
        {
            
            List<int> elementos = new List<int>();

            
            for (int i = 0; i < topo; i++)
            {
                elementos.Add(pilha[i]);
            }

            
            topo = 0;

            
            for (int i = elementos.Count - 1; i >= 0; i--)
            {
                Adicionar(elementos[i]);
            }
        }


        static void ain(string[] args)
        {
            Adicionar(10);
            Adicionar(20);
            Adicionar(30);
            Adicionar(40);
            Topo();
            System.Console.WriteLine();

            Listar();
            System.Console.WriteLine();
            Remover();
            Reverter();
            System.Console.WriteLine();

            Listar();
            System.Console.WriteLine();
            Topo();


        }
    }
}