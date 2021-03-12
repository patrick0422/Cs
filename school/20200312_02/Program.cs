using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200312_02
{
    class Program
    {
        static void Gugu(int dan)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{dan} x {i} = {dan * i}");
            }
        }
        static void Star(int col)
        {
            for (int i = 0; i <= col; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        static long Fact(int num)
        {
            long sum = 1;
            for (int i = 1; i <= num; i++)
            {
                sum *= i;
            }

            return sum;
        }
        static long RecursiveFact(int num, long sum)
        {
            if (num >= 1)
            {
                sum = RecursiveFact(num - 1, sum * num);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            for (int i = 2; i < 10; i++)
                Gugu(i);
            Console.WriteLine();
            Star(5);
            Console.WriteLine(Fact(3));
            Console.WriteLine(RecursiveFact(4, 1));
        }
    }
}