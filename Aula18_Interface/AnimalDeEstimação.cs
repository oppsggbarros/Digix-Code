using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula18_Interface
{
    public interface AnimalDeEstimacao
    {
        string GetNome();
        void SetNome(string nome);
        void Brinca();
    }
}