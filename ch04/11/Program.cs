using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8 - i; j++)
                    Console.Write(" ");
                for (int k = 1; k < 2 * i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
