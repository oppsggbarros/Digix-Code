using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe_Selada
{
    public class Executar
    {
        static void Min(string [] args)
        {
            Funcionario f = new Funcionario();
            f.Salario(1000);
            f.Trabalhar();

            Coordenador c = new Coordenador();
            c.Salario(2000);
            c.Trabalhar();

            Gerente g = new Gerente();
            g.Salario(3000);
            g.Trabalhar();

            Instrutor i = new Instrutor();
            i.Salario(4000);

        }
    }
}