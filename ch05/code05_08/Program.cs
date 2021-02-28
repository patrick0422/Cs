using System;
using System.Collections.Generic;

namespace code05_08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 52, 273, 32, 64 };

            list.Remove(52);

            foreach (var item in list)
            {
                Console.WriteLine($"Count: {list.Count}\titem: {item}");
            }
        }
    }
}
