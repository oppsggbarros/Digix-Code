using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Relacoes
{
    public class PortaSala : Porta
    {
        public PortaSala(string Cor, float Largura, float Altura, bool aberta): base(cor, largura, altura, aberta)
        {
            Cor = cor;
            Largura = largura;
            Altura = altura;

        }
    }
}