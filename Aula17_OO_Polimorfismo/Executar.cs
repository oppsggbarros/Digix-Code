using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17_OO_Polimorfismo
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Não pode instanciar uma classe abastrata, no caso "Forma"
            // Forma forma = new Forma("Quadrado");

            //  Circulo circulo = new Circulo("Circulo",5);
            //  circulo.ImprimirDados();

            //  Retangulo retangulo = new Retangulo("Retângulo",10,12);
            //  retangulo.ImprimirDados();
            
            Empregado[] empregados = new Empregado[]
        {
            new Assalariado("João", "Silva", "123.456.789-00", 3000),
            new Comissionado("Maria", "Oliveira", "987.654.321-00", 15000, 0.1),
            new Horista("Carlos", "Pereira", "456.789.123-00", 20, 160)
        };

        foreach (var empregado in empregados)
        {
            Console.WriteLine($"Nome: {empregado.Nome} {empregado.Sobrenome}, Vencimento: {empregado.Vencimento():C}");
        }
        }
    }
}