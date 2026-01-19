using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq.Expressions;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace SistemaEstudante
{
    public class AlunoBuilder
    {
        public int? Id;
        public string NomeCompleto;
        public string Cpf;
        public DateTime DataDeNascimento;
        public string Email;
        public string Telefone;
        public string Endereco;
        public int? Matricula;
        public string Curso;
        public string Turma;
        public int? AnoDeIngresso;

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


        public Aluno BuildAluno()
        {
            if 
            (
                Id == null ||
                NomeCompleto == null ||
                Cpf == null ||
                DataDeNascimento == default ||
                Email == null ||
                Telefone == null ||
                Endereco == null ||
                Matricula == null ||
                Curso == null ||
                Turma == null ||
                AnoDeIngresso == null
            )
            {
                throw new InvalidOperationException("Pessoa incompleta");
            }

            return new Aluno
            (
                Id.Value,
                NomeCompleto,
                Cpf,
                DataDeNascimento,
                Email,
                Telefone,
                Endereco,
                Matricula.Value,
                Curso,
                Turma,
                AnoDeIngresso.Value
            );
        }
    }

    public class DocenteBuilder
    {
        public int? Id;
        public string NomeCompleto;
        public string Cpf;
        public DateTime DataDeNascimento;
        public string Email;
        public string Telefone;
        public string Endereco;

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

        public Docente BuildDocente()
        {
            if 
            (
                Id == null ||
                NomeCompleto == null ||
                Cpf == null ||
                DataDeNascimento == default ||
                Email == null ||
                Telefone == null ||
                Endereco == null
            )
            {
                throw new InvalidOperationException("Pessoa incompleta");
            }

            return new Docente
            (
                Id.Value,
                NomeCompleto,
                Cpf,
                DataDeNascimento,
                Email,
                Telefone,
                Endereco
            );
        }
    }
}