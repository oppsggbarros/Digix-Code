namespace Aula_15
{
    public class Cachorro
    {
        public string Nome;
        public int Idade;
        public string Raça;

        public void escrevasaida()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Raça: {Raça}");
        }
        public int getIdadeHumano()
        {
            int idadeHumando = 0;
            if (Idade <= 1)
            {
                idadeHumando = Idade * 11;
            }
            else
            {
                idadeHumando = 22 + (Idade - 2) * 5;
            }
            return idadeHumando;
        }
    }
}