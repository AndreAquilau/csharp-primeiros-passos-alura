using System;

namespace LacoDeRepeticaoFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada");

            for (int operadorOne = 0; operadorOne <= 10; operadorOne++)
            {
                for(int operadorTwo = 0; operadorTwo <= 10; operadorTwo++)
                {
                    Console.WriteLine($"{operadorOne} x {operadorTwo} = {operadorOne * operadorTwo}");
                }
            }
        }
    }
}
