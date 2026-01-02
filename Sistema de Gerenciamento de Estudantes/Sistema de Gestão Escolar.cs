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
            Aluno aluno_validacao = new Aluno();
            string entrada;
            bool valido;
            string erro;
            int inteiro;

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
                            Console.WriteLine("Digite o Id do Aluno");
                            Função.ExecutarValidador(aluno_validacao.ValidarId);
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