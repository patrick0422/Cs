using System;
using System.Collections.Generic;

namespace code05_05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);

            foreach(var item in list)
            {
                Console.WriteLine($"Count: {list.Count}\titem: {item}");
            }
        }
    }
}
