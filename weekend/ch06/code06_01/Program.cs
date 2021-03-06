using System;

namespace code06_01
{
    class Test
    {
        public int Power(int x)
        {
            return x * x;
        }
        public int Multi(int x, int y)
        {
            return x * y;
        }
        public void Print()
        {
            Console.WriteLine("Point()가 호출되었습니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Power(10));
            Console.WriteLine(test.Power(20));
            Console.WriteLine();
            
            Console.WriteLine(test.Multi(52, 273));
            Console.WriteLine(test.Multi(103, 32));
            Console.WriteLine();
            
            test.Print();
            test.Print();
            test.Print();
        }
    }
}
