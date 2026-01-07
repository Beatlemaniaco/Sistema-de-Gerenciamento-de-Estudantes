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
        public int Id{ get;}
        public string NomeCompleto {get;}
        public string Cpf {get; private set;}
        public DateTime DataDeNascimento {get;}
        public string Email {get;}
        public string Telefone {get;}
        public string Endereco {get;}
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
    }

    public class Aluno : Pessoa
    {
        public Aluno
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