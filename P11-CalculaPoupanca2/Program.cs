using System;
using System.Globalization;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorInvestido = 1000;
            CultureInfo cultureInfo= new CultureInfo("pt-BR");

            for (int mes = 1; mes <= 12; mes++)
            {
                valorInvestido *=  1.0036;
                Console.WriteLine($"Após {mes} meses, você terá" + valorInvestido.ToString("C2", cultureInfo));
            }

            Console.ReadLine();

        }
    }
}
