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
    public abstract class Pessoa
    {
        public int Id {get; private set;}
        public string NomeCompleto {get; private set;}
        public string Cpf {get; private set;}
        public DateTime DataDeNascimento {get; private set;}
        public string Email {get; private set;}
        public string Telefone {get; private set;}
        public string Endereco {get; private set;}
        internal Pessoa
        (
            int id,
            string nomecompleto,
            string cpf,
            DateTime datadenascimento,
            string email,
            string telefone,
            string endereco
        )
        {
            Id = id;
            NomeCompleto = nomecompleto;
            Cpf = cpf;
            DataDeNascimento = datadenascimento;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }

        public (bool valido, string erro) ValidarId(string entrada)
        {
            entrada = entrada.Trim();

            if (!Funções.ValidarId(entrada, out int id, out string erro))
            {
                return (false, erro);
            }

            Id = id;
            return (true, null);
        }

        public (bool valido, string erro) ValidarNomeCompleto(string entrada)
        {
            entrada = entrada.Trim();

            if (!Funções.ValidarNomeCompleto(entrada, out string erro))
            {
                return (false, erro);
            }

            NomeCompleto = entrada;
            return(true, null);
        }

         public (bool valido, string erro) ValidarCpf(string entrada)
        {
            entrada = entrada.Trim();

            if (!Funções.ValidarCpf(entrada, out string erro))
            {
                return (false, erro);
            }

            Cpf = entrada;
            return(true, null);
        }

        public (bool valido, string erro) ValidarDataDeNascimento(string entrada)
        {
            entrada = entrada.Trim();

            if (!Funções.ValidarDataDeNascimento(entrada, out DateTime data, out string erro))
            {
                return (false, erro);
            }

            DataDeNascimento = data;
            return(true, null);
        }

        public (bool valido, string erro) ValidarEmail(string entrada)
        {
            entrada = entrada.Trim();

            if (!Funções.ValidarEmail(entrada, out string erro))
            {
                return (false, erro);
            }

            Email = entrada;
            return(true, null);
        }

        public (bool valido, string erro) ValidarTelefone(string entrada)
        {
            entrada = entrada.Trim();

            if (!Funções.ValidarTelefone(entrada, out string erro))
            {
                return (false, erro);
            }

            Telefone = entrada;
            return(true, null);
        }

        public (bool valido, string erro) ValidarEndereco(string entrada)
        {
            entrada = entrada.Trim();

            if (!Funções.ValidarEndereco(entrada, out string erro))
            {
                return (false, erro);
            }

            Endereco = entrada;
            return(true, null);
        }

    }

    public class Aluno : Pessoa
    {
        public int Matricula {get;private set;}
        public string Curso {get; private set;}
        public string Turma {get; private set;}
        public int AnoDeIngresso {get; private set;}
        internal Aluno
        (
            int id,
            string nomecompleto,
            string cpf,
            DateTime datadenascimento,
            string email,
            string telefone,
            string endereco,
            int matricula,
            string curso,
            string turma,
            int anodeingresso
        ): 
        base
        (
            id,
            nomecompleto,
            cpf,
            datadenascimento,
            email,
            telefone,
            endereco
        )
        {
            Matricula = matricula;
            Curso = curso;
            Turma = turma;
            AnoDeIngresso = anodeingresso;
        }

        public (bool valido, string erro) ValidarMatricula(string entrada)
        {
            if (!Funções.ValidarMatricula(entrada, out int matricula, out string erro))
            {
                return (false, erro);
            }

            Matricula = matricula;
            return (true, null);
        }

        public (bool valido, string erro) ValidarCurso(string entrada)
        {
            entrada = entrada.Trim();

            if (!Funções.ValidarCurso(entrada, out string erro))
            {
                return (false, erro);
            }

            Curso = entrada;
            return(true, null);
        }

        public (bool valido, string erro) ValidarTurma(string entrada)
        {
            entrada = entrada.Trim();

            if (!Funções.ValidarTurma(entrada, out string erro))
            {
                return (false, erro);
            }

            Turma = entrada;
            return(true, null);
        }

        public (bool valido, string erro) ValidarAnoDeIngresso(string entrada)
        {
            if (!Funções.ValidarAnoDeIngresso(entrada, out int anodeingresso, out string erro))
            {
                return (false, erro);
            }

            AnoDeIngresso = anodeingresso;
            return (true, null);
        }
    }

    public class Docente : Pessoa
    {
       public Docente
        (
            int id,
            string nomecompleto,
            string cpf,
            DateTime datadenascimento,
            string email,
            string telefone,
            string endereco
        ): 
        base
        (
            id,
            nomecompleto,
            cpf,
            datadenascimento,
            email,
            telefone,
            endereco
        )
        {} 
    }
}