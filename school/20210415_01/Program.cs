using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210415_01
{
    class Program
    {
        static void Main(string[] args)
        {
            new Map().Render();


            //list
            int[] arr = new int[10];
            List<int> list = new List<int>();

            // 삽입, 삭제
            list.Insert(2, 999);
            foreach(int value in list)
            {
                Console.WriteLine(value);
            }
            
            list.Remove(3);

            foreach(int value in list)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("length: " + list.Count);
        }
    }
}
