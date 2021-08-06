using System;

namespace Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 Condicionais 2");

            int idade = 16;
            int quantidadePessoa = 2;
            bool acompanhado = quantidadePessoa >= 2;
            
            if (idade >= 18 && acompanhado)
            {

                Console.WriteLine("Pode entrar");
            }
            else
            {

                Console.WriteLine("Não pode entrar");

            }
        }
    }
}
