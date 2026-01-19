using System;
using System.Text.RegularExpressions;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Reflection;

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

        public static bool ValidarId(string entrada, out int id, out string erro)
        {
            erro = null;
            id = 0;

            if (string.IsNullOrWhiteSpace(entrada))
            {
                erro = "Campo vazio não é permitido.";
                return false;
            }
            if (!int.TryParse(entrada, out id))
            {
                erro = "Somente numero inteiro";
                return false;
            }
            if (id < 0)
            {
                erro = "O ID não pode ser negativo.";
                return false;
            }

            return true;
        }

        public static bool ValidarNomeCompleto(string entrada, out string erro)
        {
            erro = null;

            if (string.IsNullOrWhiteSpace(entrada))
            {
                erro = "O Campo não pode ficar vazio";
                return false;

            }
            if (entrada.Length > 50)
            {
                erro = "Você ultrapassou o limite de caracteres";
                return false;
            }
            if (!Regex.IsMatch(entrada, @"^[\p{L}\p{M}\s]+$"))
            {
                erro = "Somente letras são perimitidas";
                return false;
            }

            return true;
        }

         public static bool ValidarCpf(string entrada, out string erro)
        {
            erro = null;

            if (string.IsNullOrWhiteSpace(entrada))
            {
                erro = "O campo não pode ficar vazio.";
                return false;
            }
            if (entrada.Length > 14 || entrada.Length < 14)
            {
                erro = "Tamanho invalido.";
                return false;
            }
            if (!Regex.IsMatch(entrada, @"^([0-9]{3}).([0-9]{3}).([0-9]{3})-([0-9]{2})$"))
            {
                erro = "Formato invalido.";
                return false;
            }

            return true;
        }

        public static bool ValidarDataDeNascimento(string entrada, out DateTime data, out string erro)
        {
            erro = null;
            data = default;

            if (!DateTime.TryParseExact(entrada, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
            {
                erro = "Entrada invalida.";
                return false;
            }
            if (data > DateTime.Today)
            {
                erro = "A data não pode ser futura.";
                return false;
            }
            if (DateTime.Today.Year - data.Year > 125)
            {
                erro = "Data Invalida";
                return false;
            }

            return true;
        }

        public static bool ValidarEmail(string entrada, out string erro)
        {
            erro = null;

            if (string.IsNullOrWhiteSpace(entrada))
            {
                erro = "O campo não pode ficar vazio.";
                return false;
            }
            if (entrada.Length > 100)
            {
                erro = "Você excedeu o limite de caracteres.";
                return false;
            }
            if (!entrada.Contains("@"))
            {
                erro = "Precisa de pelo menos um @";
                return false;
            }
            if (entrada.IndexOf("@") == 0 || entrada.IndexOf("@") == entrada.Length - 1)
            {
                erro = "Precisa de texto antes e depois do @";
                return false;
            }
            if (entrada.Contains(" "))
            {
                erro = "Email não pode conter espaços.";
                return false;
            }

            return true;
        }

        public static bool ValidarTelefone(string entrada, out string erro)
        {
            erro = null;

            if (string.IsNullOrWhiteSpace(entrada))
            {
                erro = "O campo não pode ficar vazio.";
                return false;
            }
            if (entrada.Length > 20 || entrada.Length < 8)
            {
                erro = "Quantidade de números invalida.";
                return false;
            }
            if (!Regex.IsMatch(entrada, @"(\+[1-9]{2}) ([1-9]{2}) (9[0-9])([0-9]{3})-([0-9]{4})$"))
            {
                erro = "Formato Invalido.";
                return false;
            }

            return true;
        }

        public static bool ValidarEndereco(string entrada, out string erro)
        {
            erro = null;

            if (string.IsNullOrWhiteSpace(entrada))
            {
                erro = "O Campo não pode ficar vazio";
                return false;
            }
            if (entrada.Length > 50)
            {
                erro = "Você ultrapassou o limite de caracteres";
                return false;
            }
            if (!Regex.IsMatch(entrada, @"^[\p{L}\p{M}\s]+$"))
            {
                erro = "Somente letras são perimitidas";
                return false;
            }

            return true;
        }

        public static bool ValidarMatricula(string entrada, out int matricula, out string erro)
        {
            erro = null;
            matricula = 0;

            if (string.IsNullOrWhiteSpace(entrada))
            {
                erro = "Campo vazio não é permitido.";
                return false;
            }
            if (!int.TryParse(entrada, out matricula))
            {
                erro = "Somente numero inteiro";
                return false;
            }
            if (matricula < 0)
            {
                erro = "O ID não pode ser negativo.";
                return false;
            }

            return true;
        }

        public static bool ValidarCurso(string entrada, out string erro)
        {
            erro = null;

            if (string.IsNullOrWhiteSpace(entrada))
            {
                erro = "O Campo não pode ficar vazio";
                return false;

            }
            if (entrada.Length > 50)
            {
                erro = "Você ultrapassou o limite de caracteres";
                return false;
            }
            if (!Regex.IsMatch(entrada, @"^[\p{L}\p{M}\s]+$"))
            {
                erro = "Somente letras são perimitidas";
                return false;
            }

            return true;
        }

        public static bool ValidarTurma(string entrada, out string erro)
        {
            erro = null;

            if (string.IsNullOrWhiteSpace(entrada))
            {
                erro = "O Campo não pode ficar vazio";
                return false;

            }
            if (entrada.Length > 50)
            {
                erro = "Você ultrapassou o limite de caracteres";
                return false;
            }
            if (!Regex.IsMatch(entrada, @"^[\p{L}\p{M}\s]+$"))
            {
                erro = "Somente letras são perimitidas";
                return false;
            }

            return true;
        }

        public static bool ValidarAnoDeIngresso(string entrada, out int anodeingresso, out string erro)
        {
            erro = null;
            anodeingresso = 0;

            if (string.IsNullOrWhiteSpace(entrada))
            {
                erro = "Campo vazio não é permitido.";
                return false;
            }
            if (!int.TryParse(entrada, out anodeingresso))
            {
                erro = "Somente numero inteiro";
                return false;
            }
            if (anodeingresso < 0)
            {
                erro = "O ID não pode ser negativo.";
                return false;
            }

            return true;
        }
    }
}