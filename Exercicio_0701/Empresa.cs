using System;
using System.Collections.Generic;
using System.Linq;

// Enumerações
public enum TipoEmpregado
{
    Vendedor,
    GerenteVendas,
    GerenteProducao
}

public enum StatusLicenca
{
    Aprovada,
    Pendente,
    Negada
}

public enum Regiao
{
    Norte,
    Sul,
    Leste,
    Oeste
}


public class Pessoa
{
    public string Nome { get; set; }

    public Pessoa(string nome)
    {
        Nome = nome;
    }
}

public class Empregado : Pessoa
{
    public double Salario { get; set; }
    public TipoEmpregado TipoEmpregado { get; set; }
    public StatusLicenca StatusLicenca { get; set; }
    public DateTime DataAdmissao { get; set; } 

    public Empregado(string nome, double salario, TipoEmpregado tipoEmpregado, DateTime dataAdmissao)
        : base(nome)
    {
        Salario = salario;
        TipoEmpregado = tipoEmpregado;
        StatusLicenca = StatusLicenca.Pendente;
        DataAdmissao = dataAdmissao; 
        if (salario < 240){ 
            throw new ArgumentException("Salário não pode ser abaixo do mínimo");
            }
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Salário: {Salario:C}, Tipo: {TipoEmpregado}, Status Licença: {StatusLicenca}, Data de Admissão: {DataAdmissao.ToShortDateString()}"; 
    }
    
}

public class Vendedor : Empregado
{
    
    public Regiao Regiao { get; set; }

    public Vendedor(string nome, double salario, Regiao regiao, DateTime dataAdmissao)
        : base(nome, salario, TipoEmpregado.Vendedor, dataAdmissao)
    {
        Regiao = regiao;
    }
        

    public override string ToString()
    {
        return base.ToString() + $", Região: {Regiao}";
    }
}

public class GerenteVendas : Empregado
{
    public GerenteVendas(string nome, double salario, DateTime dataAdmissao)
        : base(nome, salario, TipoEmpregado.GerenteVendas, dataAdmissao)
    {
    }
}

public class GerenteProducao : Empregado
{
    public GerenteProducao(string nome, double salario, DateTime dataAdmissao)
        : base(nome, salario, TipoEmpregado.GerenteProducao, dataAdmissao)
    {
    }
}



public class Program
{
    public static void Main(string[] args)
    {
        List<Empregado> empregados = new List<Empregado>
        {
            new Vendedor("João", 30, Regiao.Norte, DateTime.Now.AddYears(-1)),
            new GerenteVendas("Maria", 5000, DateTime.Now.AddYears(-2)),
            new GerenteProducao("Carlos", 4500, DateTime.Now.AddYears(-3)),
            new Vendedor("Ana", 3200, Regiao.Sul, DateTime.Now.AddMonths(-6)),
            
        };

        Console.WriteLine("Empregados categorizados por tipo:\n");
        foreach (var grupo in empregados.GroupBy(e => e.TipoEmpregado))
        {
            Console.WriteLine($"Tipo: {grupo.Key}");
            foreach (var empregado in grupo)
            {
                Console.WriteLine(empregado);
            }
            Console.WriteLine();
        }

        empregados[0].StatusLicenca = StatusLicenca.Aprovada;
        empregados[1].StatusLicenca = StatusLicenca.Negada;


        Console.WriteLine("Status de licença atualizado:\n");
        foreach (var empregado in empregados)
        {
            Console.WriteLine(empregado);
        }
    }
}
