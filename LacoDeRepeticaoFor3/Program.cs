using System;

namespace LacoDeRepeticaoFor3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int line = 0; line < 10; line++)
            {
                for (int column = 0; column < line; column++)
                {
                    if(column > line)
                    {
                        break;
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
