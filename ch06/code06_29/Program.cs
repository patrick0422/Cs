﻿using System;

namespace code06_29
{
    class Box
    {
        private int width;
        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0) { width = value; }
                else { Console.WriteLine("넓이는 자연수를 입력해주세요"); }
            }
        }
        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) { width = value; }
                else { Console.WriteLine("넓이는 자연수를 입력해주세요"); }
            }
        }

        public Box(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Area() { return this.width * this.height; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(-10, -20);

            box.Width = -200;
            box.Height = -100;
        }
    }
}