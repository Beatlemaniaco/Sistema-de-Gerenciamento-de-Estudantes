using System;

namespace SistemaEstudante
{
    public class Funções
    {
        public static void ExecutarValidador(string pergunta, Func<string, (bool valido, string erro)>validar)
        {
            bool valido;
            do{
                Console.WriteLine(pergunta);
                string entrada = Console.ReadLine();
                var resultado = validar(entrada);

                valido = resultado.valido;

                if (!resultado.valido)
                {
                    Console.WriteLine(resultado.erro);
                }
            } while (!valido);
        }
    }
}