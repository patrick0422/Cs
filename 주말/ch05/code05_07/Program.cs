using System;
using System.Collections.Generic;

namespace code05_07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 52, 273, 32, 64 };

            foreach (var item in list)
            {
                Console.WriteLine($"Count: {list.Count}\titem: {item}");
            }
        }
    }
}
