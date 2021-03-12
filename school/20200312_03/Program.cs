using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200312_03
{
    enum Jobs
    {
        KNIGHT = 1,
        DOCTOR = 2,
        LYRICS = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            bool done = false;
            while(!done)
            {
                Console.WriteLine("직업을 선택하세요");
                Console.WriteLine("[1] 기사\r\n[2] 의사\r\n[3] 가사");

                choice = Int32.Parse(Console.ReadLine());

                switch(choice)
                {
                    case (int)Jobs.KNIGHT:
                        Console.WriteLine("당신은 기사가 되었습니다.");
                        done = true;
                        break;
                    case (int)Jobs.DOCTOR:
                        Console.WriteLine("당신은 의사가 되었습니다.");
                        done = true;
                        break;
                    case (int)Jobs.LYRICS:
                        Console.WriteLine("당신은 가사가 되었습니다.");
                        done = true;
                        break;
                }
            }
        }
    }
}
