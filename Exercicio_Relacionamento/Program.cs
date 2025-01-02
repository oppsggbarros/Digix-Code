using System;
using System.Collections.Generic;

// Classe Abstrata Usuario
public abstract class Usuario
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public string CPF { get; set; }

    protected Usuario(string nome, string endereco, string telefone, string cpf)
    {
        Nome = nome;
        Endereco = endereco;
        Telefone = telefone;
        CPF = cpf;
    }
}

// Classe Fornecedor
public class Fornecedor : Usuario
{
    public string CNPJ { get; set; }
    public double TaxaDesconto { get; set; }

    public Fornecedor(string nome, string endereco, string telefone, string cnpj, double taxaDesconto = 0)
        : base(nome, endereco, telefone, null)
    {
        CNPJ = cnpj;
        TaxaDesconto = taxaDesconto;
    }
}

// Classe Produto
public class Produto
{
    public string Nome { get; set; }
    public int Codigo { get; set; }
    public Fornecedor Fornecedor { get; set; }
    public double PrecoCusto { get; set; }
    public double PrecoFinal { get; set; }
    public bool Perecivel { get; set; }
    public DateTime? DataValidade { get; set; }
    public string Apelido { get; set; }

    public Produto(string nome, int codigo, Fornecedor fornecedor, double precoCusto, double precoFinal, bool perecivel = false, DateTime? dataValidade = null, string apelido = null)
    {
        Nome = nome;
        Codigo = codigo;
        Fornecedor = fornecedor;
        PrecoCusto = precoCusto;
        PrecoFinal = precoFinal;
        Perecivel = perecivel;
        DataValidade = dataValidade;
        Apelido = apelido;
    }
}

// Classe Abstrata Funcionario
public abstract class Funcionario : Usuario
{
    public double SalarioBase { get; set; }

    protected Funcionario(string nome, string endereco, string cpf, string telefone, double salarioBase)
        : base(nome, endereco, telefone, cpf)
    {
        SalarioBase = salarioBase;
    }

    public abstract double CalcularSalario();
}

// Classe Vendedor
public class Vendedor : Funcionario
{
    public double MontanteVendas { get; set; }

    public Vendedor(string nome, string endereco, string cpf, string telefone, double salarioBase)
        : base(nome, endereco, cpf, telefone, salarioBase)
    {
        MontanteVendas = 0;
    }

    public override double CalcularSalario()
    {
        double bonificacao = MontanteVendas > 10000 ? 0.1 * SalarioBase : 0;
        return SalarioBase + bonificacao;
    }
}

// Classe Gerente
public class Gerente : Funcionario
{
    public Gerente(string nome, string endereco, string cpf, string telefone, double salarioBase)
        : base(nome, endereco, cpf, telefone, salarioBase) { }

    public override double CalcularSalario()
    {
        return SalarioBase * 1.2;
    }
}

// Classe Padeiro
public class Padeiro : Funcionario
{
    public int HorasTrabalhadasNoturnas { get; set; }

    public Padeiro(string nome, string endereco, string cpf, string telefone, double salarioBase, int horasTrabalhadasNoturnas = 0)
        : base(nome, endereco, cpf, telefone, salarioBase)
    {
        HorasTrabalhadasNoturnas = horasTrabalhadasNoturnas;
    }

    public override double CalcularSalario()
    {
        double gratificacao = 0.25 * SalarioBase * HorasTrabalhadasNoturnas;
        return SalarioBase + gratificacao;
    }
}

// Classe Cliente
public class Cliente : Usuario
{
    public string TipoFidelidade { get; set; }

    public Cliente(string nome, string endereco, string telefone, string cpf)
        : base(nome, endereco, telefone, cpf) { }
}

// Classe Venda
public class Venda
{
    public List<Produto> Produtos { get; set; }
    public Funcionario Vendedor { get; set; }
    public string FormaPagamento { get; set; }
    public DateTime Data { get; set; }

    public Venda(List<Produto> produtos, Funcionario vendedor, string formaPagamento, DateTime? data = null)
    {
        Produtos = produtos;
        Vendedor = vendedor;
        FormaPagamento = formaPagamento;
        Data = data ?? DateTime.Now;
    }
}

// Classe Estoque
public class Estoque
{
    private Dictionary<int, (Produto produto, int quantidade)> produtos;

    public Estoque()
    {
        produtos = new Dictionary<int, (Produto, int)>();
    }

    public void AdicionarProduto(Produto produto, int quantidade)
    {
        if (produtos.ContainsKey(produto.Codigo))
        {
            produtos[produto.Codigo] = (produtos[produto.Codigo].produto, produtos[produto.Codigo].quantidade + quantidade);
        }
        else
        {
            produtos[produto.Codigo] = (produto, quantidade);
        }
    }

    public void RemoverProduto(int codigo, int quantidade)
    {
        if (produtos.ContainsKey(codigo))
        {
            var (produto, qtdAtual) = produtos[codigo];
            if (qtdAtual >= quantidade)
            {
                if (qtdAtual == quantidade)
                {
                    produtos.Remove(codigo);
                }
                else
                {
                    produtos[codigo] = (produto, qtdAtual - quantidade);
                }
            }
            else
            {
                throw new InvalidOperationException("Quantidade insuficiente em estoque.");
            }
        }
        else
        {
            throw new KeyNotFoundException("Produto não encontrado no estoque.");
        }
    }

    public bool VerificarProduto(int codigo)
    {
        return produtos.ContainsKey(codigo);
    }

    public void EmitirAlerta()
    {
        foreach (var item in produtos)
        {
            if (item.Value.quantidade < 1)
            {
                Console.WriteLine($"Alerta: O produto {item.Value.produto.Nome} está esgotado.");
            }
        }
    }
}

// Classe Imposto
public class Imposto
{
    public double CalcularImpostoVendas(double totalVendas)
    {
        return totalVendas * 0.15;
    }

    public double CalcularImpostoSalarios(double totalSalarios)
    {
        return totalSalarios * 0.18;
    }
}

// Classe SistemaGestao
public class SistemaGestao
{
    private List<Funcionario> funcionarios;
    private List<Cliente> clientes;
    private Estoque estoque;
    private List<Venda> vendas;

    public SistemaGestao()
    {
        funcionarios = new List<Funcionario>();
        clientes = new List<Cliente>();
        estoque = new Estoque();
        vendas = new List<Venda>();
    }

    public void AdicionarFuncionario(Funcionario funcionario)
    {
        funcionarios.Add(funcionario);
    }

    public void AdicionarCliente(Cliente cliente)
    {
        clientes.Add(cliente);
    }

    public void RegistrarVenda(Venda venda)
    {
        vendas.Add(venda);
        foreach (var produto in venda.Produtos)
        {
            estoque.RemoverProduto(produto.Codigo, 1); // Assume que cada venda é de 1 unidade por produto
        }
    }

    public void EmitirRelatorioFuncionarios()
    {
        foreach (var funcionario in funcionarios)
        {
            Console.WriteLine($"Nome: {funcionario.Nome}, CPF: {funcionario.CPF}, Salário: {funcionario.CalcularSalario()}");
        }
    }

    public void EmitirRelatorioClientes()
    {
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"Nome: {cliente.Nome}, CPF: {cliente.CPF}, Tipo de Fidelidade: {cliente.TipoFidelidade}");
        }
    }
}