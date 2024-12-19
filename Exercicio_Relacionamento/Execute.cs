using System;
using System.Collections.Generic;
namespace Exercicio_Relacionamento
{
    public class Execute{
        static void Mn(string[] args)
        {
            
            Estado estado = new Estado { nome = "São Paulo", sigla = "SP" };
            Cidade cidade = new Cidade { nome = "São Paulo", estado = estado };

            
            Endereco endereco = new Endereco
            {
                rua = "Avenida Paulista",
                numero = 1578,
                bairro = "Bela Vista",
                cep = "01310-200",
                cidade = cidade
            };

            
            Funcionario funcionario = new Funcionario
            {
                nome = "João Silva",
                nascimento = new DateTime(1990, 5, 20),
                cpf = "123.456.789-00",
                enderecos = new List<Endereco> { endereco }
            };

            
            Vendedor vendedor = new Vendedor
            {
                nome = "Maria Oliveira",
                nascimento = new DateTime(1985, 3, 15),
                cpf = "987.654.321-00",
                enderecos = new List<Endereco> { endereco },
                equipe = new EquipeVenda { nome = "Equipe A" }
            };

            
            Console.WriteLine($"Funcionario: {funcionario.getNome()}, CPF: {funcionario.getCpf()}, Data de Nascimeno: {funcionario.getNascimento()}, Endereço: {endereco.rua } {endereco.numero} {endereco.bairro}, {endereco.cep}");
            Console.WriteLine($"Vendedor: {vendedor.getNome()}, Equipe: {vendedor.equipe.nome}");
        }
    }
}