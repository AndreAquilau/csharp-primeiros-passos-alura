using System;
using System.Globalization;
using System.Timers;

namespace _3_CriandoVariaveisPontoFlutuantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 Criando variavel ponto flutuante");

            double salario;
            salario = 1200.00;

            CultureInfo corrency = new CultureInfo("pt-BR");

            Console.WriteLine(salario.ToString("C2", corrency));

            double idade;
            idade = 15.00 / 2.0;

            idade = 5 / 3;

            Console.WriteLine(idade);

            Console.WriteLine($"5 / 3 = {idade}");

            idade = 5.0 / 3;

            Console.WriteLine("5.0 / 3 "+idade);

            Console.WriteLine("A execução acabou. Tecle enter para sair...");
            Console.ReadKey();
        }
    }
}
