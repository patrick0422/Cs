using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200312_01
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        static void AddSub(int a, int b, out int add, out int sub)
        {
            add = a + b;
            sub = a - b;
        }

        static void Swap(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void RefSwap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int a = 2, b = 3;
            Console.WriteLine($"{a}, {b}");
            RefSwap(ref a, ref b);
            Console.WriteLine($"{a}, {b}");

            int add, sub;

            AddSub(a, b, out add, out sub);

            Console.WriteLine($"합: {add}, 차: {sub}");
        }
    }
}