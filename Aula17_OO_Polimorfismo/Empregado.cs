using System;
namespace Aula17_OO_Polimorfismo
{
    
    public abstract class Empregado
    {
        public string Nome;
        public string Sobrenome;
        public string Cpf;

        
        public abstract double Vencimento();
    }
}