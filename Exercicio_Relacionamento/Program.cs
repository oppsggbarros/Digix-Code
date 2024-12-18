using System;
using System.Collections.Generic;
namespace Exercicio_Relacionamento
{
    public class Funcionario {
        
        public string nome;
        public DateTime nascimento;
        public string cpf;
        public List<Endereco> enderecos;
        
        
        public string getNome() {
            return nome;
        }
        
        public DateTime getNascimento() {
            return nascimento;
        }
        
        public string getCpf() {
            return cpf;
        }
        
        public List<Endereco> getEnderecos() {
            return enderecos;
        }
    }

    public class Vendedor : Funcionario {
        
        public EquipeVenda equipe;
        
        
        public float getSalario() {
            
            return 0.0f;
        }
    }

    public class Gerente : Funcionario {
        
        public void getSalario() {
        }
    }

    public class EquipeVenda : Vendedor {
        
        public string nome;
    }

    public class Endereco {
        
        public string rua;
        public int numero;
        public string bairro;
        public string cep;
        public Cidade cidade;
    }

    public class Cidade {
        
        public string nome;
        public Estado estado;
    }

    public class Estado {
        
        public string nome;
        public string sigla;
    }
}