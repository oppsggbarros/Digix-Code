using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Execicio02_01
{
    public class Pessoa
    {
        private string nome;
        private string cpf;

        public Pessoa(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetCpf()
        {
            return cpf;
        }

        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }
    }

    public class Engenheiro : Pessoa
    {
        private int crea;

        public Engenheiro(string nome, string cpf, int crea) : base(nome, cpf)
        {
            this.crea = crea;
        }

        public int GetCrea()
        {
            return crea;
        }

        public void SetCrea(int crea)
        {
            this.crea = crea;
        }
    }

    public abstract class Edificacao
    {
        protected float metragemTotal;
        protected string endereco;
        protected Engenheiro responsavel;
        protected List<UnidadeResidencial> unidades;

        public Edificacao(float metragemTotal, string endereco, Engenheiro responsavel)
        {
            this.metragemTotal = metragemTotal;
            this.endereco = endereco;
            this.responsavel = responsavel;
            this.unidades = new List<UnidadeResidencial>();
        }

        public float GetMetragemTotal()
        {
            return metragemTotal;
        }

        public void SetMetragemTotal(float met)
        {
            metragemTotal = met;
        }

        public string GetEndereco()
        {
            return endereco;
        }

        public void SetEndereco(string end)
        {
            endereco = end;
        }

        public Engenheiro GetResponsavel()
        {
            return responsavel;
        }

        public void SetResponsavel(Engenheiro eng)
        {
            responsavel = eng;
        }

        public List<UnidadeResidencial> GetUnidades()
        {
            return unidades;
        }

        public bool CadastrarUnidade(UnidadeResidencial novaUnid)
        {
            unidades.Add(novaUnid);
            return true;
        }

        public abstract string DescricaoDoImovel();
    }

    public class UnidadeResidencial
    {
        private float metragemUnidade;
        private int numQuartos;
        private int numBanheiros;
        private Pessoa proprietario;

        public UnidadeResidencial(float metragemUnidade, int numQuartos, int numBanheiros, Pessoa proprietario)
        {
            this.metragemUnidade = metragemUnidade;
            this.numQuartos = numQuartos;
            this.numBanheiros = numBanheiros;
            this.proprietario = proprietario;
        }

        public float GetMetragemUnidade()
        {
            return metragemUnidade;
        }

        public void SetMetragemUnidade(float metragem)
        {
            metragemUnidade = metragem;
        }

        public int GetNumQuartos()
        {
            return numQuartos;
        }

        public void SetNumQuartos(int nQuartos)
        {
            numQuartos = nQuartos;
        }

        public int GetNumBanheiros()
        {
            return numBanheiros;
        }

        public void SetNumBanheiros(int nBan)
        {
            numBanheiros = nBan;
        }

        public Pessoa GetProprietario()
        {
            return proprietario;
        }

        public void SetProprietario(Pessoa prop)
        {
            proprietario = prop;
        }
    }

    public class Predio : Edificacao
    {
        private string nome;
        private int numAndares;
        private int numApartamentosPorAndar;

        public Predio(string nome, int numAndares, int numApartamentosPorAndar, float metragemTotal, string endereco, Engenheiro responsavel)
            : base(metragemTotal, endereco, responsavel)
        {
            this.nome = nome;
            this.numAndares = numAndares;
            this.numApartamentosPorAndar = numApartamentosPorAndar;
        }

        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public int GetNumAndares()
        {
            return numAndares;
        }

        public void SetNumAndares(int num)
        {
            numAndares = num;
        }

        public int GetNumApartamentosPorAndar()
        {
            return numApartamentosPorAndar;
        }

        public void SetNumApartamentosPorAndar(int num)
        {
            numApartamentosPorAndar = num;
        }
        public class Casa : Edificacao
        {
            private bool condominio;

            public Casa(float metragemTotal, string endereco, Engenheiro responsavel, bool condominio)
                : base(metragemTotal, endereco, responsavel)
            {
                this.condominio = condominio;
            }

            public bool GetCondominio()
            {
                return condominio;
            }

            public void SetCondominio(bool cond)
            {
                condominio = cond;
            }

            public override string DescricaoDoImovel()
            {
                return $"Casa situada a {endereco} com {metragemTotal}m², em condomínio: {(condominio ? "Sim" : "Não")}. " +
                       $"Responsável: {responsavel.GetNome()}.";
            }
        }

        public class CasaSobrado : Casa
        {
            private int numAndares;

            public CasaSobrado(float metragemTotal, string endereco, Engenheiro responsavel, bool condominio, int numAndares)
                : base(metragemTotal, endereco, responsavel, condominio)
            {
                this.numAndares = numAndares;
            }

            public int GetNumAndares()
            {
                return numAndares;
            }

            public void SetNumAndares(int num)
            {
                this.numAndares = num;
            }

            public override string DescricaoDoImovel()
            {
                return base.DescricaoDoImovel() + $" Número de andares: {numAndares}.";
            }
        }


        public override string DescricaoDoImovel()
        {
            StringBuilder descricao = new StringBuilder();
            descricao.AppendLine($"Prédio {nome}.");
            descricao.AppendLine($"Situado a {endereco}.");
            descricao.AppendLine($"Área total: {metragemTotal} metros quadrados.");
            descricao.AppendLine($"Responsável: {responsavel.GetNome()}. CREA {responsavel.GetCrea()}.");
            descricao.AppendLine($"Número de Andares: {numAndares}.");
            descricao.AppendLine($"Número de Apartamentos por Andar: {numApartamentosPorAndar}.");

            for (int i = 0; i < unidades.Count; i++)
            {
                UnidadeResidencial unidade = unidades[i];
                descricao.AppendLine($"Unidade {i + 1}");
                descricao.AppendLine($"Propriedade de {unidade.GetProprietario().GetNome()}.");
                descricao.AppendLine($"Possui {unidade.GetMetragemUnidade()} metros quadrados, {unidade.GetNumQuartos()} quartos, {unidade.GetNumBanheiros()} banheiros.");
            }

            return descricao.ToString();
        }
        static void Man(string[] args)
        {
            Engenheiro engenheiro1 = new Engenheiro("Ana Souza", "123.456.789-00", 12345);

            Pessoa proprietario1 = new Pessoa("Carlos Silva", "987.654.321-00");
            Pessoa proprietario2 = new Pessoa("Maria Oliveira", "456.123.789-00");

            UnidadeResidencial unidade1 = new UnidadeResidencial(80.5f, 2, 2, proprietario1);
            UnidadeResidencial unidade2 = new UnidadeResidencial(100.0f, 3, 3, proprietario2);

            Predio predio = new Predio("Residencial Aurora", 10, 4, 1000.0f, "Rua das Flores, 123", engenheiro1);
            predio.CadastrarUnidade(unidade1);
            predio.CadastrarUnidade(unidade2);

            Casa casa = new Casa(200.0f, "Av. Central, 456", engenheiro1, true);

            CasaSobrado sobrado = new CasaSobrado(150.0f, "Rua do Sol, 789", engenheiro1, false, 2);

            CasaTerrea casaTerrea = new CasaTerrea(120.0f, "Travessa do Norte, 321", engenheiro1, true);

            Console.WriteLine("Descrição dos Imóveis:");

            Console.WriteLine("\nPrédio:");
            Console.WriteLine(predio.DescricaoDoImovel());

            Console.WriteLine("\nCasa:");
            Console.WriteLine(casa.DescricaoDoImovel());

            Console.WriteLine("\nCasa Sobrado:");
            Console.WriteLine(sobrado.DescricaoDoImovel());

            Console.WriteLine("\nCasa Térrea:");
            Console.WriteLine(casaTerrea.DescricaoDoImovel());
        }
        public class CasaTerrea : Casa
        {
            public CasaTerrea(float metragemTotal, string endereco, Engenheiro responsavel, bool condominio)
                : base(metragemTotal, endereco, responsavel, condominio) { }

            public override string DescricaoDoImovel()
            {
                return base.DescricaoDoImovel() + " Este é um imóvel térreo.";
            }
        }
    }
}