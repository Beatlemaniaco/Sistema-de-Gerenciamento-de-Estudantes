using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;

namespace SistemaEstudante
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();
            PessoaBuilder builder = new PessoaBuilder();

            Console.WriteLine("Bem Vindo ao Sistema de Gestão Escolar!!!!!");
            Console.WriteLine("");
            Console.WriteLine("1 - Alunos.");
            Console.WriteLine("2 - Docentes");
            Console.WriteLine("3 - Curso.");
            Console.WriteLine("4 - Matricula.");
            Console.WriteLine("5 - Notas.");
            Console.WriteLine("0 - Sair.");
            int opcao_menuinicial = Convert.ToInt32(Console.ReadLine());

            switch (opcao_menuinicial)
            {
                case 1:
                    Console.WriteLine("Lista de Alunos.");
                    Console.WriteLine("1 - Adicionar Aluno");
                    Console.WriteLine("2 - Atualizar Aluno.");
                    Console.WriteLine("3 - Remover Aluno.");
                    Console.WriteLine("4 - Procurar Aluno.");
                    Console.WriteLine("5 - Ordenar Lista");
                    Console.WriteLine("0 - Sair.");
                    int opcao_aluno = Convert.ToInt32(Console.ReadLine());

                    switch (opcao_aluno)
                    {
                        case 1:
                            Funções.ExecutarValidador("Qual é o Id do Aluno:", builder.ValidarId);
                            Funções.ExecutarValidador("Qual é o Nome Completo do Aluno:", builder.ValidarNomeCompleto);
                            Funções.ExecutarValidador("Qual é o CPF do aluno(000.000.000-00):", builder.ValidarCpf);
                            Funções.ExecutarValidador("Qual é a Data de Nascimento do Aluno(dd/MM/yyyy):", builder.ValidarDataDeNascimento);
                            Funções.ExecutarValidador("Qual é o Email Do Aluno ou Responsavel:", builder.ValidarEmail);
                            Funções.ExecutarValidador("Qual é o Telefone Do Aluno ou Responsavel(+00 00 00000-0000):", builder.ValidarTelefone);
                            Aluno aluno = builder.Build();
                            Funções.ExecutarValidador("Qual é o Endereço do Aluno:", builder.ValidarEndereco);
                            Aluno aluno2 = builder.Build();
                            alunos.Add(aluno);
                            Console.WriteLine($"ID: {alunos[0].Id} || Nome: {alunos[0].NomeCompleto}");
                            Console.WriteLine($"CPF: {alunos[0].Cpf} || Data De Nascimento: {DateOnly.FromDateTime(alunos[0].DataDeNascimento)}");
                            Console.WriteLine($"Email: {alunos[0].Email} || Telefone: {alunos[0].Telefone}");
                            Console.WriteLine($"Endereço: {alunos[0].Endereco}");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Lista de Docentes.");
                    Console.WriteLine("1 - Adicionar Docente");
                    Console.WriteLine("2 - Atualizar Docente.");
                    Console.WriteLine("3 - Remover Docente.");
                    Console.WriteLine("4 - Procurar Docente.");
                    Console.WriteLine("5 - Ordenar Lista");
                    Console.WriteLine("0 - Sair.");
                    break;
                case 3:
                    Console.WriteLine("Lista de Cursos.");
                    Console.WriteLine("1 - Adicionar Curso");
                    Console.WriteLine("2 - Atualizar Curso.");
                    Console.WriteLine("3 - Remover Curso.");
                    Console.WriteLine("4 - Procurar Curso.");
                    Console.WriteLine("5 - Ordenar Lista");
                    Console.WriteLine("0 - Sair.");
                    break;
            }
        }
    }
}