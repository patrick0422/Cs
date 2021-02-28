using System;

namespace pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");                
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10 - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
