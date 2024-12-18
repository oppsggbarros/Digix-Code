using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Relacoes
{
    public class Escola
    {
        private Aluno estudante;
        private Professor professor;
        public Escola (string nomeEstudante)
        {
            estudante = new Aluno(nomeEstudante);
        }
        public void ContratarProfessor(Professor professor)
        {
            this.professor = professor;
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome do estudante: {estudante.Nome}");
            Console.WriteLine($"Nome do professor: {professor.Nome}");
            professor.Ensinar();
        }
    }
}