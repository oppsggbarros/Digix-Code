using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_14
{
    public class ListaDuplamenteEncadeada
    {
        private class Node
        {
            public int Valor { get; set; }
            public Node Proximo { get; set; }
            public Node Anterior { get; set; }

            public Node(int valor)
            {
                Valor = valor;
                Proximo = null;
                Anterior = null;
            }
        }

        private Node? Inicio { get; set; }

        public void Inserir(int valor)
        {
            var novoNode = new Node(valor);
            if (Inicio == null)
            {
                Inicio = novoNode;
            }
            else
            {
                var atual = Inicio;
                while (atual.Proximo != null)
                {
                    atual = atual.Proximo;
                }
                atual.Proximo = novoNode;
                novoNode.Anterior = atual;
            }
        }

        public void Excluir(int valor)
        {
            if (Inicio == null)
            {
                Console.WriteLine("Lista vazia");
                return;
            }

            if (Inicio.Valor == valor)
            {
                if (Inicio.Proximo != null)
                {
                    Inicio.Proximo.Anterior = null;
                }
                Inicio = Inicio.Proximo;
                return;
            }

            var atual = Inicio;
            while (atual != null && atual.Valor != valor)
            {
                atual = atual.Proximo;
            }

            if (atual != null)
            {
                if (atual.Anterior != null)
                {
                    atual.Anterior.Proximo = atual.Proximo;
                }
                if (atual.Proximo != null)
                {
                    atual.Proximo.Anterior = atual.Anterior;
                }
            }
        }
        public void RemoverTodas(int valor)
        {
            if (Inicio == null)
            {
                Console.WriteLine("Lista vazia");
                return;
            }

            var atual = Inicio;

            while (atual != null)
            {
                if (atual.Valor == valor)
                {
                    // Se o nó a ser removido é o primeiro
                    if (atual.Anterior == null)
                    {
                        Inicio = atual.Proximo; // Atualiza o início da lista
                        if (Inicio != null) // Se a lista não fica vazia
                        {
                            Inicio.Anterior = null; // Remove a referência anterior do novo primeiro nó
                        }
                    }
                    else
                    {
                        // Ajusta o ponteiro do nó anterior
                        atual.Anterior.Proximo = atual.Proximo;
                    }

                    if (atual.Proximo != null) // Se não é o último nó
                    {
                        // Ajusta o ponteiro do nó seguinte
                        atual.Proximo.Anterior = atual.Anterior;
                    }
                }

                // Avança para o próximo nó
                atual = atual.Proximo;
            }
        }

        public void Listar()
        {
            var atual = Inicio;
            while (atual != null)
            {
                Console.WriteLine(atual.Valor);
                atual = atual.Proximo;
            }
        }

        public static void Main()
        {
            var lista = new ListaDuplamenteEncadeada();
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            lista.Inserir(20);
            lista.Inserir(40);

            Console.WriteLine("Lista antes da remoção:");
            lista.Listar();

            lista.RemoverTodas(20);

            Console.WriteLine("Lista após a remoção de todas as ocorrências de 20:");
            lista.Listar();
        }
    }
}
