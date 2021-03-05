using System;

namespace code06_30
{
    class Test
    {
        public int value = 10;
    }
    class Program
    {
        static void Change(Test input)
        {
            input.value = 20;
        }
        static void Main(string[] args)
        {
            Test test = new Test();
            test.value = 10;
            Change(test);

            Console.WriteLine(test.value);
        }
    }
}
