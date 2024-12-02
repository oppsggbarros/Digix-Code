using System;

class Program
{
    static void Man(string[] args)
    {
        int[] data = new int[100]; // Array para armazenar os dados
        int[] next = new int[100]; // Array para armazenar os índices dos próximos nós
        int head = -1; // Índice do primeiro nó
        int freeIndex = 0; // Índice do próximo espaço livre no array

        // Função para adicionar um novo nó
        void Add(int value)
        {
            if (freeIndex >= data.Length) return; // Verifica se há espaço

            data[freeIndex] = value; // Armazena o valor
            next[freeIndex] = -1; // Define o próximo como -1 (nó final)

            if (head == -1) // Se a lista estiver vazia
            {
                head = freeIndex; // O novo nó se torna o head
            }
            else
            {
                int current = head;
                while (next[current] != -1) // Percorre até o último nó
                {
                    current = next[current];
                }
                next[current] = freeIndex; // Adiciona o novo nó ao final
            }

            freeIndex++; // Avança para o próximo índice livre
        }

        // Função para exibir a lista
        void Display()
        {
            int current = head;
            while (current != -1) // Percorre a lista
            {
                Console.Write(data[current] + " ");
                current = next[current]; // Move para o próximo nó
            }
            Console.WriteLine();
        }

        // Função para remover um nó
        void Remove(int value)
        {
            if (head == -1) return; // Se a lista estiver vazia

            if (data[head] == value) // Se o nó a ser removido é o primeiro
            {
                head = next[head]; // Atualiza o head
                return;
            }

            int current = head;
            int previous = -1;

            while (current != -1 && data[current] != value) // Procura pelo nó
            {
                previous = current;
                current = next[current];
            }

            if (current == -1) return; // Se o nó não foi encontrado

            next[previous] = next[current]; // Remove o nó
        }

        // Testando a lista
        Add(10);
        Add(20);
        Add(30);
        Add(40);
        Add(50);
        Add(60);
        Add(70);
        Add(80);
        Add(90);
        Add(100);
        Add(150);

        Console.WriteLine("Lista após adições:");
        Display();

        Remove(20);

        Console.WriteLine("Lista após remoção do 20:");
        Display();
    }
}