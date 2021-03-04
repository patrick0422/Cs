using System;

namespace code06_19
{
    class Sample
    {
        public static int value;

        static Sample()
        {
            value = 10;
            Console.WriteLine("정적 생성자 호출");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("두 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("세 번째 위치");
        }
    }
}
