
namespace Aula8;
public class Mudificadores
{
    public int soma(int a, int b){
        return a + b;
    }
    static int subtracao(int a, int b){
        return a - b;
    }
    static void bbb(string[] args)
    {
        Mudificadores n = new Mudificadores();
        Console.WriteLine(n.soma(10, 20));
        Console.WriteLine(subtracao(10, 20));
    }
}