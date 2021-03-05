using System;

namespace _13
{
    class Program
    {
        static string prev_num = "1";
        static int count = 0;

        static void Main(string[] args)
        {
            string num = "1";

            for (int i = 0; i < 20; i++)
            {
                num = Calc2(num);
            }

            Console.WriteLine("Final Result = " + num);
        }
        static string Calc(string number)
        {
            int[] cnt = { 0, 0, 0 };
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i].Equals('1'))
                    cnt[0]++;
                else if (number[i].Equals('2'))
                    cnt[1]++;
                else if (number[i].Equals('3'))
                    cnt[2]++;
            }

            Console.WriteLine($"{number} => {cnt[0]} {cnt[1]} {cnt[2]}");

            string output = "";
            if (cnt[0] != 0)
                output = string.Concat("1" + cnt[0].ToString());
            if (cnt[1] != 0)
                output = string.Concat(output + "2" + cnt[1].ToString());
            if (cnt[2] != 0)
                output = string.Concat(output + "3" + cnt[2].ToString());

            Console.WriteLine("output = " + output);
            Console.WriteLine();
            
            return output;
        }

        static string Calc2(string number)
        {
            count++;

            int[] cnt = { 0, 0, 0 };
            string output = "";

            Console.WriteLine("input = " + number);

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i].Equals('1'))
                { 
                    if (prev_num != "1")
                    {
                        makeOutput();
                    }

                    cnt[0]++;
                    prev_num = "1";
                }
                else if (number[i].Equals('2'))
                {
                    if (prev_num != "2")
                    {
                        makeOutput();
                    }

                    cnt[1]++;
                    prev_num = "2";
                }
                else if (number[i].Equals('3'))
                {
                    if (prev_num != "3")
                    {
                        makeOutput();
                    }
                    
                    cnt[2]++;
                    prev_num = "3";
                }                    
            }

            void makeOutput()
            {
                Console.WriteLine($"현재 cnt: 1=>{cnt[0]}, 2=>{cnt[1]}, 3=>{cnt[2]}");
                
                // Make Output
                if (cnt[0] != 0)
                    output = string.Concat(output + "1" + cnt[0].ToString());
                if (cnt[1] != 0)
                    output = string.Concat(output + "2" + cnt[1].ToString());
                if (cnt[2] != 0)
                    output = string.Concat(output + "3" + cnt[2].ToString());

                // Init cnt[]
                cnt[0] = 0;
                cnt[1] = 0;
                cnt[2] = 0;

                Console.WriteLine("output setted to = " + output);

                return;
            }

            makeOutput();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(count + "번째 output = " + output);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            return output;
        }
    }
}
