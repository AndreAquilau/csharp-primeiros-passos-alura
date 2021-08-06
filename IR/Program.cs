using System;

namespace IR
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.00;

            if(salario >= 3751.01)
            {
                Console.WriteLine("R$ 636,00");
            }
            else if (salario >= 2800.01)
            {
                Console.WriteLine("R$ 350,00");
            }
            else if(salario >= 1900.0)
            {
                Console.WriteLine("R$ 142,00");
            }
            else
            {
                Console.WriteLine("Sem declaração IR");
            }
        }
    }
}
