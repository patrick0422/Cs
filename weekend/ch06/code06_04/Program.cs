using System;

namespace code06_04
{
    class Test
    {
        public int Sum(int min, int max)
        {
            int output = 0;
            for (int i = min; i <= max; i++)
            {
                output += i;
            }

            return output;
        }
        public long Multiply(int min, int max)
        {
            long output = 1;

            for (int i = min; i <= max; i++)
            {
                output *= i;
            }

            return output;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Sum(1, 100));
            Console.WriteLine();
            Console.WriteLine(test.Multiply(1, 10));
        }
    }
}
