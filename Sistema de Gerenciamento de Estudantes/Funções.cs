using System;

namespace SistemaEstudante
{
    public class Função
    {
        public static int ValidarInteiro(string entrada)
        {
            if (!int.TryParse(entrada, out int variavel))
            {
                throw new ("Dado Invalido");
            }
            return variavel;
        }

        public static void ExecutarValidador(Func<string, (bool valido, string erro)>validar)
        {
            bool valido;
            do{
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