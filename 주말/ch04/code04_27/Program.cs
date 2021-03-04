using System;

namespace code04_27
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "감자 고구마 토마토";
            string[] inputs = input.Split(' ');

            foreach(var i in inputs)
            {
                Console.WriteLine(i);
            }
        }
    }
}
