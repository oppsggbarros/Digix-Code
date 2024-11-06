
namespace Aula9;
public class FuncaoFlexivel
{
    public delegate int Operacao(int a, int b);
    public delegate void Notificar();
    public static void EnviarEmail() => Console.WriteLine("Enviado");
    public static void EnviarSMS() => Console.WriteLine("Enviado");

    static int Soma(int a, int b) => a + b;
        static void Main(string[] args)
    {
            // Operacao op = Soma;
            // Console.WriteLine(op(3, 2));
            // Operacao op2 = int (int a) 
            Notificar notificar = EnviarEmail;
            notificar += EnviarSMS;
            notificar();


    }
}