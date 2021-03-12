using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210311_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요 >> ");


            int num = Int32.Parse(Console.ReadLine());

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(num +"은 안소수... 무야호~");
                    return;
                }
            }

            Console.WriteLine(num + "은 소수... 무야호~");

            return;
        }
    }
}