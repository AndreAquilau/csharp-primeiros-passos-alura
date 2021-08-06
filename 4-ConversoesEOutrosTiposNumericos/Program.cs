using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;
            Console.WriteLine(salario);

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            long idade = 1300000000000;
            Console.WriteLine(idade);

            short quantidadeProduto = 15000;
            Console.WriteLine(quantidadeProduto);

            float altura = 1.80F;
            Console.WriteLine(altura);


            Console.ReadKey();
        }
    }
}
