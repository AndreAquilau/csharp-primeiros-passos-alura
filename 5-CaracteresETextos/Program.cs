using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");
            char primeiraLetra = ' ';

            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;

            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            
            Console.WriteLine(primeiraLetra);

            string title = "Alura curso de tecnologia " + 2020;

            Console.WriteLine(title);
           
            string vazia = "";

            Console.WriteLine(vazia);

            string cursoProgramacao = "- .NET \n- Java \n- Javascript";
            
            Console.WriteLine(cursoProgramacao);

            Console.ReadKey();
        }
    }
}
