using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("출생년도를 입력하세요: ");
            int input = Convert.ToInt32(Console.ReadLine());
            
            string[] data =
            {
                "원숭이", "닭", "개", "돼지", "쥐", "소", "범", "토끼", "용", "뱀", "말", "양"
            };

            Console.WriteLine($"{input}년생은 {data[input%12]}띠 입니다.");
        }
    }
}
