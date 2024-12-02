using System;

public class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }
    public Node<T> Previous { get; set; }

    public Node(T data)
    {
        Data = data;
        Next = null;
        Previous = null;
    }
}

public class DoublyLinkedList<T>
{
    private Node<T> head;
    private Node<T> tail;

    public DoublyLinkedList()
    {
        head = null;
        tail = null;
    }

    public void AddFirst(T data)
    {
        Node<T> newNode = new Node<T>(data);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head.Previous = newNode;
            head = newNode;
        }
    }

    public void AddLast(T data)
    {
        Node<T> newNode = new Node<T>(data);
        if (tail == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Previous = tail;
            tail = newNode;
        }
    }

    public void Remove(T data)
    {
        Node<T> current = head;

        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }

                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    tail = current.Previous;
                }
                return;
            }
            current = current.Next;
        }
    }

    public void PrintList()
    {
        Node<T> current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    public void PrintListReverse()
    {
        Node<T> current = tail;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Previous;
        }
        Console.WriteLine();
    }
}

public class ListaDuplamenteEncadeada

{
    public static void Mn(string[] args)
    {
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        list.AddFirst(10);
        list.AddFirst(20);
        list.AddLast(30);
        list.AddLast(40);

        Console.WriteLine("Lista:");
        list.PrintList();

        Console.WriteLine("Removendo 20:");
        list.Remove(20);
        list.PrintList();

        Console.WriteLine("Lista em ordem reversa:");
        list.PrintListReverse();
    }
}