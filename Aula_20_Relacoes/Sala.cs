using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_20_OO_Relacoes.Exemplo;

namespace Aula_20_Relacoes
{
    public class Sala
    {
        public PortaSala PortaSala { get; set; }
        public Porta PortaAuxiliar { get; set; }
        public float MetragemQuadrada { get; set; }

        public Sala(PortaSala portaSala, PortaAuxiliar portaAuxiliar, float metragemQuadrada)
        {
            PortaAuxiliar = portaAuxiliar;
            MetragemQuadrada = metragemQuadrada;
            PortaSala = new PortaSala(portaSala.Cor, portaSala.Largura, portaSala.Altura);

        }
        public void AbrirPortaAuxiliar()
        {
            PortaAuxiliar.Abrir();
        }
    }
}