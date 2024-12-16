using System;

public class Animal
{
    public int pernas = 0;

    public Animal()
    {
        // Constructor
    }

    public void caminha()
    {
        Console.WriteLine("O animal está caminhando.");
    }

    public void come()
    {
        Console.WriteLine("O animal está comendo.");
    }
}

public interface AnimalDeEstimacao
{
    string getNome();
    void setNome(string nome);
    void brinca();
}

public class Formiga : Animal
{
    public Formiga()
    {
        // Constructor
    }

    public void come()
    {
        Console.WriteLine("A formiga está comendo.");
    }
}

public class Cachorro : Animal, AnimalDeEstimacao
{
    private string nome;

    public Cachorro()
    {
        // Constructor
    }

    public Cachorro(string nome)
    {
        this.nome = nome;
    }

    public string getNome()
    {
        return nome;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public void brinca()
    {
        Console.WriteLine("O cachorro está brincando.");
    }

    public void come()
    {
        Console.WriteLine("O cachorro está comendo.");
    }
}

public class Peixe : Animal, AnimalDeEstimacao
{
    private string nome;

    public Peixe()
    {
        // Constructor
    }

    public string getNome()
    {
        return nome;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public void brinca()
    {
        Console.WriteLine("O peixe está brincando.");
    }

    public void come()
    {
        Console.WriteLine("O peixe está comendo.");
    }
}

public class MainClass
{
    public static void Min(string[] args)
    {
        // Criar um objeto Formiga
        Formiga formiga = new Formiga();
        formiga.come();

        // Criar um objeto Cachorro
 Cachorro cachorro = new Cachorro("Rex");
        cachorro.come();
        cachorro.brinca();
        Console.WriteLine("Nome do cachorro: " + cachorro.getNome());

        // Criar um objeto Peixe
        Peixe peixe = new Peixe();
        peixe.setNome("Nemo");
        peixe.come();
        peixe.brinca();
        Console.WriteLine("Nome do peixe: " + peixe.getNome());
    }
}