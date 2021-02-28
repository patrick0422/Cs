using System;
using System.Threading;

namespace code04_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("두 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("세 번째 출력");
        }
    }
}
