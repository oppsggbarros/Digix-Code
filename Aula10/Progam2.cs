using System;
namespace Ref
{
    class Progasmd
    {
        static int Quadrado(int x)
        {
            return x * x;
        }
        static void Quadradoref(ref int x)
        {
            x = x * x; 
        }
        static void Main(string[] args)
        {
            int a = 10;
            System.Console.WriteLine(Quadrado(a));
            System.Console.WriteLine(a);
        }
    }
}