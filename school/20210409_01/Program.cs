using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200409_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] b = new int[5];

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = i;
            }

            int[] c = new int[5] { 10, 20, 30, 40, 50 };
            int[] d = { 1, 3, 7, 2, 6, 9, 23, 5 };

            Console.WriteLine($"Max: {Max(d)}");
            Console.WriteLine($"Average: {Average(d)}");

            int target = 23;
            Console.WriteLine($"Index of {target}: {IndexOf(target, d)}");
        }

        static int Max(int[] arr)
        {
            int max = 0;

            foreach(int i in arr)
                max = (i > max) ? i : max;

            return max;
        }
        static double Average(int[] arr)
        {
            double avg = 0;

            if (arr.Length == 0)
                return 0;

            foreach (int i in arr)
                avg += i;

            return avg / arr.Length;
        }
        static int IndexOf(int x, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == x)
                    return i;
            return -1;
        }
    }
}
