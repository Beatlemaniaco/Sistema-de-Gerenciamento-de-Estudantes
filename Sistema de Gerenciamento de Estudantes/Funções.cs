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
    }
}