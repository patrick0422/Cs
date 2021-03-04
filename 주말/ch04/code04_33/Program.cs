using System;

namespace code04_33
{
    class Program
    {
        static void Main(string[] args)
        {
            bool state = true;

            int x = 0, y = 0;

            while (state)
            {
                ConsoleKeyInfo info = Console.ReadKey();

                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (y > 0)
                            y--;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (x > 1)
                            x -= 2;
                        break;
                    case ConsoleKey.RightArrow:
                        x += 2;
                        break;
                    case ConsoleKey.X:
                        state = false;
                        break;
                }
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write("@");
            }
        }
    }
}
