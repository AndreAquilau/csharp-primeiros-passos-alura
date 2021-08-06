using System;
using System.Globalization;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorInvestido = 1000;
            int mes = 1;

            CultureInfo cultureInfo = new CultureInfo("pt-BR");

            while(mes <= 12)
            {

                valorInvestido += valorInvestido * 0.0036;
                Console.WriteLine($"Após {mes} mês, você terá " + valorInvestido.ToString("C2", cultureInfo));
                mes++;
            }

            Console.ReadKey();
        }
    }
}
