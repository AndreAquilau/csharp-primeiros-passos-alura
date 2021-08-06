using System;
using System.Globalization;

namespace P12CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");
            double fatorRendimento = 1.0036;
            double valorInvertimento = 1000;
            CultureInfo culture = new CultureInfo("pt-BR");

            for (int ano = 1; ano <= 5; ano++)
            {
                for (int mes = 1; mes <= 12; mes++)
                {
                    valorInvertimento *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }
            Console.WriteLine($"Ao término do investimento, você terá" + valorInvertimento.ToString("C2", culture));
        }
    }
}
