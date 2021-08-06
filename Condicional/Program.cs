using System;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando Condicionais");

            int idade = 16;
            int quantidadePessoa = 3;

            if (idade >= 18)
            {
                Console.WriteLine("Você tem mais que 18 anos");

                Console.WriteLine("Seja Bem Vindo");
            }
            else
            {
                if (quantidadePessoa >= 2)
                {
                    Console.WriteLine("Você não tem 18, mas pode entrar," +
                        " pois está acompanhado");
                }
                else
                {
                    Console.WriteLine("Infelizmente você não pode entrar");
                }
            }
        }
    }
}
