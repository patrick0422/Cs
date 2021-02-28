using System;

namespace code06_26
{
    class Box
    {
        private int width;
        private int height;

        public Box(int width, int height)
        {
            if (width > 0 || height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("너비와 높이는 자연수로 초기화해주세요!");
            }
        }

        public int Area() { return width * height; }

        public int GetWidth() { return width; }
        public int GetHeight() { return height; }

        public void SetWidth(int width) { this.width = width > 0 ? width : -width; }
        public void SetHeight(int height) { this.height = height > 0 ? height : -height; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
