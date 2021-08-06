using System;

namespace AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6");

            int idade = 32;
            int idadeGustado = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustado);

            Console.ReadKey();
        }
    }
}
