using System;

namespace code06_25
{
    class Product
    {
        private static int count;
        public readonly int id;
        public string name;
        public int price;

        public Product(string name, int price)
        {
            id = count++;
            this.name = name;
            this.price = price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
