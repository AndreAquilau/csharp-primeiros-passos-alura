using System;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 13");


            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
               
                for(int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    if(contadorColuna < contadorLinha)
                    {
                        Console.Write("*");
                    } 
                    else
                    {
                        Console.WriteLine();
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
