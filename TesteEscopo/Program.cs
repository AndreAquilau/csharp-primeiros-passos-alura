using System;

namespace TesteEscopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste Escopo");

            int idade = 20;
            int quantidadePessoa = 3;
            bool acompanhado = true;


            if (quantidadePessoa >= 2)
            {
                acompanhado = true;
            }
            else
            {
                acompanhado = false;
            }

            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("Infelizmente voce nao pode entrar");
            }
        }
    }
}
