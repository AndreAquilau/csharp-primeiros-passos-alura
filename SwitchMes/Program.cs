using System;

namespace SwitchMes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Condicional Switch");

            int mes = 10;

            switch(mes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 10:
                    Console.WriteLine("Outubro");
                    break;
                default:
                    Console.WriteLine("opção Invalida");
                    break;
            }
        }
    }
}
