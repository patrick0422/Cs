using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200409_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 3, 6, 1, 2, 4 };

            Sort(arr);

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void Sort(int[] arr)
        {
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int j;
                for (j = i; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                        min = j;
                }

                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }
    }
}