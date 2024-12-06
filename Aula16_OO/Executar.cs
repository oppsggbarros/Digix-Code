using System;
using Aula_16_OO;
namespace Aula_16_OO
{

    public class Executar
    {
        static void Main(string[] args)
        {
            double total;
            Carnes carne = new Carnes("Alcatra", 35.69, 5);
            total += carne.CalcularEstoque();

            Petiscos petiscos = new Petiscos("Torresmo", 11.99, 4);
            total += petiscos.CalcularEstoque();

            Laticinios laticinios = new Laticinios("Iorgute", 12.99, 2);
            total += laticinios.CalcularEstoque();

            Limpeza limpeza = new Limpeza("Ypê Detergente Neutro", 3.50, 50);
            total += limpeza.CalcularEstoque();

            Ferramentas ferramentas = new Ferramentas("Chave de Fenda", 18.60, 1);
            total += ferramentas.CalcularEstoque();

        }
    }
}