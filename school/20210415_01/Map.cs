using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210415_01
{
    internal class Map
    {
        int[,] tiles =
        {
            {1,1,1,1,1},
            {1,0,0,0,1},
            {1,0,0,0,1},
            {1,0,0,0,1},
            {1,1,1,1,1},
        };

        public void Render()
        {
            ConsoleColor defaultColor = Console.ForegroundColor;

            int length = 5;
            for (int y = 0; y < length; y++)
            {
                for (int x = 0; x < tiles.GetLength(0); x++)
                {
                    if (tiles[y,x] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write('\u25cf');
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = defaultColor;
        }
    }
}
