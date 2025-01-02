using System;


public abstract class Veiculo
{
    public string Modelo { get; set; }
    public double ValorLocacao { get; set; } 
    public double ImpostoLocacao { get; set; } 

    public Veiculo(string modelo, double valorLocacao, double impostoLocacao)
    {
        Modelo = modelo;
        ValorLocacao = valorLocacao;
        ImpostoLocacao = impostoLocacao;
    }

    public abstract double CalcularValorDiaria();
}


public class Caminhao : Veiculo
{
    public int NumeroEixos { get; set; }

    public Caminhao(string modelo, double valorLocacao, double impostoLocacao, int numeroEixos)
        : base(modelo, valorLocacao, impostoLocacao)
    {
        NumeroEixos = numeroEixos;
    }

    public override double CalcularValorDiaria()
    {
        return ValorLocacao + ImpostoLocacao + (NumeroEixos * 10);
    }
}


public class CarroPasseio : Veiculo
{
    public string Categoria { get; set; } 

    public CarroPasseio(string modelo, double valorLocacao, double impostoLocacao, string categoria)
        : base(modelo, valorLocacao, impostoLocacao)
    {
        Categoria = categoria;
    }

    public override double CalcularValorDiaria()
    {
        double fatorCategoria = Categoria switch
        {
            "A" => 1.0,
            "B" => 1.1,
            "C" => 1.2,
            _ => 1.0
        };
        return (ValorLocacao + ImpostoLocacao) * fatorCategoria;
    }
}


public class Utilitario : Veiculo
{
    public bool IsFurgao { get; set; } // True se for furgão, false se for caminhonete

    public Utilitario(string modelo, double valorLocacao, double impostoLocacao, bool isFurgao)
        : base(modelo, valorLocacao, impostoLocacao)
    {
        IsFurgao = isFurgao;
    }

    public override double CalcularValorDiaria()
    {
        double fatorTipo = IsFurgao ? 1.15 : 1.25;
        return (ValorLocacao + ImpostoLocacao) * fatorTipo;
    }
}


public class Moto : Veiculo
{
    public int Cilindrada { get; set; }

    public Moto(string modelo, double valorLocacao, double impostoLocacao, int cilindrada = 125)
        : base(modelo, valorLocacao, impostoLocacao)
    {
        Cilindrada = cilindrada;
    }

    public override double CalcularValorDiaria()
    {
        double fatorCilindrada = Cilindrada switch
        {
            <= 125 => 1.0,
            <= 250 => 1.2,
            > 250 => 1.5
        };
        return (ValorLocacao + ImpostoLocacao) * fatorCilindrada;
    }
}

// Exemplo de uso
public class Program
{
    public static void Man()
    {
        Caminhao caminhao = new Caminhao("Caminhao Volvo", 200, 50, 3);
        Console.WriteLine($"Diária do caminhão: {caminhao.CalcularValorDiaria()} reais");

        CarroPasseio carro = new CarroPasseio("Sedan Luxo", 100, 20, "B");
        Console.WriteLine($"Diária do carro: {carro.CalcularValorDiaria()} reais");

        Utilitario utilitario = new Utilitario("Furgão Mercedes", 150, 30, true);
        Console.WriteLine($"Diária do utilitário: {utilitario.CalcularValorDiaria()} reais");

        Moto moto = new Moto("Moto Yamaha", 50, 10, 300);
        Console.WriteLine($"Diária da moto: {moto.CalcularValorDiaria()} reais");
    }
}
