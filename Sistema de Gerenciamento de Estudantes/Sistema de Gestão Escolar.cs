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
            List<Docente> docentes = new List<Docente>();
            AlunoBuilder builder_aluno = new AlunoBuilder();
            DocenteBuilder builder_docente = new DocenteBuilder();
            int opcao_menu;
            int opcao_aluno, opcao_docente;
            int contador = 0;

            do{
                Console.WriteLine("Bem Vindo ao Sistema de Gestão Escolar!!!!!");
                Console.WriteLine("1 - Alunos.");
                Console.WriteLine("2 - Docentes");
                Console.WriteLine("3 - Curso.");
                Console.WriteLine("4 - Matricula.");
                Console.WriteLine("5 - Notas.");
                Console.WriteLine("0 - Sair.");
                opcao_menu = Convert.ToInt32(Console.ReadLine());

                switch (opcao_menu)
                {
                    case 1:
                        do{
                            Console.WriteLine("Lista de Alunos.");
                            Console.WriteLine("1 - Adicionar Aluno");
                            Console.WriteLine("2 - Atualizar Aluno.");
                            Console.WriteLine("3 - Remover Aluno.");
                            Console.WriteLine("4 - Procurar Aluno.");
                            Console.WriteLine("5 - Ordenar Lista");
                            Console.WriteLine("0 - Sair.");
                            opcao_aluno = Convert.ToInt32(Console.ReadLine());

                            switch (opcao_aluno)
                            {
                                case 1:
                                    Funções.ExecutarValidador("Qual é o Id do Aluno:", builder_aluno.ValidarId);
                                    Funções.ExecutarValidador("Qual é o Nome Completo do Aluno:", builder_aluno.ValidarNomeCompleto);
                                    Funções.ExecutarValidador("Qual é o CPF do aluno(000.000.000-00):", builder_aluno.ValidarCpf);
                                    Funções.ExecutarValidador("Qual é a Data de Nascimento do Aluno(dd/MM/yyyy):", builder_aluno.ValidarDataDeNascimento);
                                    Funções.ExecutarValidador("Qual é o Email Do Aluno ou Responsavel:", builder_aluno.ValidarEmail);
                                    Funções.ExecutarValidador("Qual é o Telefone Do Aluno ou Responsavel(+00 00 00000-0000):", builder_aluno.ValidarTelefone);
                                    Funções.ExecutarValidador("Qual é o Endereço do Aluno:", builder_aluno.ValidarEndereco);
                                    Funções.ExecutarValidador("Qual é o Número de Matricula do Aluno:", builder_aluno.ValidarMatricula);
                                    Funções.ExecutarValidador("Qual é o Curso do Aluno:", builder_aluno.ValidarCurso);
                                    Funções.ExecutarValidador("Qual é a Turma do Aluno:", builder_aluno.ValidarTurma);
                                    Funções.ExecutarValidador("Qual é o Ano de Ingresso do Aluno:", builder_aluno.ValidarAnoDeIngresso);
                                    Aluno aluno = builder_aluno.BuildAluno();
                                    alunos.Add(aluno);
                                    break;
                                case 2:
                                    for (int i = 0; i < alunos.Count; i++)
                                    {
                                        Console.WriteLine($"{i + 1}. {alunos[i].Id}|| {alunos[i].NomeCompleto}");
                                        contador++;
                                    }
                                    Console.WriteLine("0 - Sair");
                                    Console.WriteLine("Qual Aluno Você Irá Atualizar:");
                                    int opcao_atualizar = Convert.ToInt32(Console.ReadLine());

                                    if (opcao_atualizar < alunos.Count + 1 && opcao_atualizar > 0)
                                    {
                                        Console.WriteLine($"{alunos[contador - 1].NomeCompleto}");
                                        Console.WriteLine("1 - Id.");
                                        Console.WriteLine("2 - Nome Completo.");
                                        Console.WriteLine("3 - CPF.");
                                        Console.WriteLine("4 - Data de Nascimento");
                                        Console.WriteLine("5 - Email.");
                                        Console.WriteLine("6 - Telefone.");
                                        Console.WriteLine("7 - Endereço.");
                                        Console.WriteLine("8 - Número de Matricula");
                                        Console.WriteLine("9 - Curso.");
                                        Console.WriteLine("10 - Turma.");
                                        Console.WriteLine("11 - Ano de Ingresso.");
                                        Console.WriteLine("0 - Sair");
                                        Console.WriteLine("O Que Você Quer Atualizar no Aluno:");
                                        opcao_aluno = Convert.ToInt32(Console.ReadLine());

                                        switch (opcao_aluno)
                                        {
                                            case 1:
                                                Funções.ExecutarValidador("Qual é o Id do Aluno:", alunos[contador - 1].ValidarId);
                                                break;
                                            case 2:
                                                Funções.ExecutarValidador("Qual é o Nome Completo do Aluno:", alunos[contador - 1].ValidarNomeCompleto);
                                                break;
                                            case 3:
                                                Funções.ExecutarValidador("Qual é o CPF do aluno(000.000.000-00):", alunos[contador - 1].ValidarCpf);
                                                break;
                                            case 4:
                                                Funções.ExecutarValidador("Qual é a Data de Nascimento do Aluno(dd/MM/yyyy):", alunos[contador - 1].ValidarDataDeNascimento);
                                                break;
                                            case 5:
                                                Funções.ExecutarValidador("Qual é o Email Do Aluno ou Responsavel:", alunos[contador - 1].ValidarEmail);
                                                break;
                                            case 6:
                                                Funções.ExecutarValidador("Qual é o Telefone Do Aluno ou Responsavel(+00 00 00000-0000):", alunos[contador - 1].ValidarTelefone);
                                                break;
                                            case 7:
                                                Funções.ExecutarValidador("Qual é o Endereço do Aluno:", alunos[contador - 1].ValidarEndereco);
                                                break;
                                            case 8:
                                                Funções.ExecutarValidador("Qual é o Número de Matricula do Aluno:", alunos[contador - 1].ValidarMatricula);
                                                break;
                                            case 9:
                                                Funções.ExecutarValidador("Qual é o Curso do Aluno:", alunos[contador - 1].ValidarCurso);
                                                break;
                                            case 10:
                                                Funções.ExecutarValidador("Qual é a Turma do Aluno:", alunos[contador - 1].ValidarTurma);
                                                break;
                                            case 11:
                                                Funções.ExecutarValidador("Qual é o Ano de Ingresso do Aluno:", alunos[contador - 1].ValidarAnoDeIngresso);
                                                break;
                                            default:
                                                Console.WriteLine("Tente Novamente!!!!");
                                                break;
                                        }
                                    } 
                                    else if (opcao_atualizar == 0)
                                    {
                                        
                                    } 
                                    else
                                    {
                                        Console.WriteLine("Opção Invalida!!!!");
                                    }
                                    break;
                                case 3:
                                    for (int i = 0; i < alunos.Count; i++)
                                    {
                                        Console.WriteLine($"{i + 1}. {alunos[i].Id}|| {alunos[i].NomeCompleto}");
                                    }
                                    Console.WriteLine("0 - Sair.");
                                    Console.WriteLine("Qual Aluno Você Irá Remover:");
                                    int opcao_remover = Convert.ToInt32(Console.ReadLine());
                                    
                                    if (opcao_remover < alunos.Count + 1 && opcao_remover > 0)
                                    {
                                        alunos.RemoveAt(opcao_remover - 1);
                                    }
                                    else if (opcao_remover == 0)
                                    {
                                        
                                    }
                                    else
                                    {
                                       Console.WriteLine("Opção Invalida!!!!"); 
                                    }
                                    break;
                            }
                        } while (opcao_aluno != 0);
                        break;
                    case 2:
                        do{
                            Console.WriteLine("Lista de Docentes.");
                            Console.WriteLine("1 - Adicionar Docente");
                            Console.WriteLine("2 - Atualizar Docente.");
                            Console.WriteLine("3 - Remover Docente.");
                            Console.WriteLine("4 - Procurar Docente.");
                            Console.WriteLine("5 - Ordenar Lista");
                            Console.WriteLine("0 - Sair.");
                            opcao_docente = Convert.ToInt32(Console.ReadLine());

                            switch (opcao_docente)
                            {
                                case 1:
                                    Funções.ExecutarValidador("Qual é o Id do Docente:", builder_docente.ValidarId);
                                    Funções.ExecutarValidador("Qual é o Nome Completo do Docente:", builder_docente.ValidarNomeCompleto);
                                    Funções.ExecutarValidador("Qual é o CPF do Docente(000.000.000-00):", builder_docente.ValidarCpf);
                                    Funções.ExecutarValidador("Qual é a Data de Nascimento do Docente(dd/MM/yyyy):", builder_docente.ValidarDataDeNascimento);
                                    Funções.ExecutarValidador("Qual é o Email Do Docente:", builder_docente.ValidarEmail);
                                    Funções.ExecutarValidador("Qual é o Telefone Do Docente(+00 00 00000-0000):", builder_docente.ValidarTelefone);
                                    Funções.ExecutarValidador("Qual é o Endereço do Docente:", builder_docente.ValidarEndereco);
                                    Docente docente = builder_docente.BuildDocente();
                                    docentes.Add(docente);
                                    break;
                            }
                        } while (opcao_docente != 0);
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
            } while (opcao_menu != 0);
        }
    }
}