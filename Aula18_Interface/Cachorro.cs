using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula18_Interface
{
    public class Cachorro : Animal, AnimalDeEstimacao
{
    private string? nome;

    public Cachorro()
    {
    }

    public Cachorro(string nome)
    {
        this.nome = nome;
    }

    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public void Brinca()
    {
        Console.WriteLine("O cachorro está brincando");
    }

    public void Come()
    {
        Console.WriteLine("O cachorro está comendo");
    }
}
}