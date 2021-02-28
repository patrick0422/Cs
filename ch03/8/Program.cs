using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = Convert.ToInt32(Console.ReadLine());

            if (month >= 3 && month <= 5)
            {
                Console.WriteLine("봄");
            }
            else if (month >= 6 && month <= 8)
            {
                Console.WriteLine("여름");
            }
            else if (month >= 9 && month <= 11)
            {
                Console.WriteLine("가을");
            }
            else if (month == 12 || month <= 2)
            {
                Console.WriteLine("겨울");
            }
        }
    }
}