using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace SistemaEstudante
{
    abstract class Pessoa
    {
        public int Id {get; private set;}
        public string NomeCompleto {get; private set;}
        public string Cpf {get; private set;}
        public DateTime DataDeNascimento {get; private set;}
        public string Email {get; private set;}
        public string Telefone {get; private set;}
        public string Endereco {get; private set;}
        public DateTime DataDeCadastro {get; private set;}
        public status Status {get; private set;}
        public sexo Sexo {get; private set;}
        public enum status
        {
            ATIVO = 1,
            INATIVO = 2,
            BLOQUEADO = 3
        }
        public enum sexo
        {
             Masculino = 1,
             Feminino = 2,
             Outro = 3,
             Não_Informado = 4
        }

        public (bool valido, string erro) ValidarId(string entrada)
        {
            if (string.IsNullOrWhiteSpace(entrada))
            {
                return(false, "O campo não pode ficar vazio.");
            }
            if (!int.TryParse(entrada, out int id))
            {
                return (false, "Tem que ser um número inteiro.");
            }
            if (id < 0)
            {
                return(false, "O ID não pode ser negativo.");
            }

            Id = id;
            return(true, null);
        }

        public (bool valido, string erro) ValidarNomeCompleto(string entrada)
        {
            entrada = entrada.Trim();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                return(false, "O Campo não pode ficar vazio");

            }
            if (entrada.Length > 50)
            {
                return(false, "Você ultrapassou o limite de caracteres");
            }
            if (!Regex.IsMatch(entrada, @"^[\p{L}\p{M}\s]+$"))
            {
                return (false, "Somente letras são perimitidas");
            }

            NomeCompleto = entrada;
            return(true, null);
        }

        public (bool valido, string erro) ValidarCpf(string entrada)
        {
            entrada = entrada.Trim();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                return(false, "O campo não pode ficar vazio.");
            }
            if (entrada.Length > 14 || entrada.Length < 14)
            {
                return(false, "Tamanho invalido.");
            }
            if (!Regex.IsMatch(entrada, @"^([0-9]{3}).([0-9]{3}).([0-9]{3})-([0-9]{2})$"))
            {
                return(false, "Formato invalido.");
            }

            Cpf = entrada;
            return(true, null);
        }
    }

    class Aluno : Pessoa
    {
        private int matricula;
        private string curso;
        private string periodo;
        private DateTime data_cadastro;
        private status Status;
        private List<Materia> materias;
        private Dictionary<Materia, double> notas;
        private double MediaGeral;
        private bool estado_matricula;

        private enum status
        {
            ATIVO = 1,
            INATIVO = 2,
            BLOQUEADO = 3
        }

        public int Matricula
        {
            get {return matricula;}
            set {matricula = value;}
        }
        public string Curso
        {
            get {return Curso;}
            set {curso = value;}
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
    }
}