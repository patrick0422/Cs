using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210415_02
{
    class Program
    {
        public static void Main()
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            int min = 100, max = 0;

            get_max_min(arr, ref min, ref max);

            Console.WriteLine(min);
            Console.WriteLine(max);
}
        private static void get_max_min(int[] arr, ref int min, ref int max)
        {
            foreach (int i in arr)
            {
                if (i < min)
                    min = i;
                if (i > max)
                    max = i;
            }
        }

    }
}
