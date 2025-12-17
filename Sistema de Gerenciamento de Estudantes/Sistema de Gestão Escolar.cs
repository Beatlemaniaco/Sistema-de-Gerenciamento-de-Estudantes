using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;

namespace SistemaEstudante
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno pessoa = new Aluno();

            Console.WriteLine("Digite o ID:");
            string entrada_id = Console.ReadLine();

            try
            {
                pessoa.Id = Função.ValidarInteiro(entrada_id);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine(pessoa.Id);
        }
    }
}