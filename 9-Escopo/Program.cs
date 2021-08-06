using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");
            int idadeJoao = 18;
            int quantidadePessoa = 2;
            string mensagemAdicional;
            bool acompanhado = quantidadePessoa >= 2;

            if (acompanhado)
            {
                mensagemAdicional = "João está acompanhado!";
            }
            else
            {
                mensagemAdicional = "João não está acompanhado";
            }


            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine(mensagemAdicional);
            }

            Console.ReadKey();
        }
    }
}
