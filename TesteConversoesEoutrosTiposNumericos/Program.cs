using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesteConversoesEoutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            float pontoFlutuante = 3.14F;
            
            double salario = 1270.50;
            int valor = (int)salario;
            
            Console.WriteLine(valor);

            double valor1 = 0.1;
            double valor2 = 0.2;
            double total = valor1 + valor2;

            Console.WriteLine(total);




        }
    }
}
