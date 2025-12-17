using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace SistemaEstudante
{
    abstract class Pessoa
    {
        private int id = 0;
        private string nome_completo;
        private string cpf;
        private DateTime data_de_nascimento;
        private string email;
        private int telefone;
        private string endereco;
        private DateTime data_cadastro;
        private status Status;
        private sexo Sexo;
        private enum status
        {
            ATIVO = 1,
            INATIVO = 2,
            BLOQUEADO = 3
        }
        private enum sexo
        {
             Masculino = 1,
             Feminino = 2,
             Outro = 3,
             Não_Informado = 4
        }

        public int Id
        {
            get {return id;}
            set {
                if (value < 0)
                {
                    throw new ArgumentException("Números negativos não são permitidos!!!!!");
                }
                id = value;}
        }
        public string NomeCompleto
        {
            get {return nome_completo;}
            set {nome_completo = value;}
        }
        public string Cpf
        {
            get {return cpf;}
            set {cpf = value;}
        }
        public DateTime DataDeNascimento
        {
            get {return data_de_nascimento;}
            set {data_de_nascimento = value;}
        }
        public string Email
        {
            get {return email;}
            set {email = value;}
        }
        public int Telefone
        {
            get {return telefone;}
            set {telefone = value;}
        }
        public string Endereco
        {
            get {return endereco;}
            set {endereco = value;}
        }
        public DateTime DataCadastro
        {
            get {return data_cadastro;}
            set {data_cadastro = value;}
        }
        public string StatusDescrição
        {
            get => Status.ToString();
        }
        public string SexoDescrição
        {
            get => Sexo.ToString();
        }
    }

    class Aluno : Pessoa
    {
        
    }
}