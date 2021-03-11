using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210311_01
{
    class Program
    {
        enum Choices : int 
        { 
            SCISSOR,
            ROCK,
            PAPER
        }

        int choice, randChoice;
        static void Print(int choice, int randChoice, string result)
        {
            string[] list = { "가위", "바위", "보" };
            Console.WriteLine($"{list[choice]} : {list[randChoice]} - {result}");
        }
        static void Main()
        {

            Console.Write("입력>> ");

            try
            {
                int choice = Int32.Parse(Console.ReadLine());
                int randChoice = new Random().Next(0, 3);

                if (choice == randChoice)
                    Print(choice, randChoice, "비김");
                else
                {
                    switch (choice)
                    {
                        case (int)Choices.SCISSOR:
                            if (randChoice == (int)Choices.ROCK)
                                Print(choice, randChoice, "짐");
                            else if (randChoice == (int)Choices.PAPER)
                                Print(choice, randChoice, "이김");
                            break;
                        case (int)Choices.ROCK:
                            if (randChoice == (int)Choices.PAPER)
                                Print(choice, randChoice, "짐");
                            else if (randChoice == (int)Choices.SCISSOR)
                                Print(choice, randChoice, "이김");
                            break;
                        case (int)Choices.PAPER:
                            if (randChoice == (int)Choices.SCISSOR)
                                Print(choice, randChoice, "짐");
                            else if (randChoice == (int)Choices.ROCK)
                                Print(choice, randChoice, "이김");
                            break;
                        default:
                            Console.WriteLine("쉽지 않음");
                            break;
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("쉽지 않은 입력값");
            }
        }
    }
}
