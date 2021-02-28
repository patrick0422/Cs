using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("숫자를 입력해주세요: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("-----------------------------");

            int min = arr[0], max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                    min = arr[i];
                if (max < arr[i])
                    max = arr[i];
            }
            Console.WriteLine("가장 큰 수:" + max);
            Console.WriteLine("가장 작은 수:" + min);
        }
    }
}
