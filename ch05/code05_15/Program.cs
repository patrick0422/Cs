using System;

namespace code05_15
{
    class Product
    {
        public string name;
        public int price;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product pr1 = new Product() { name = "감자", price = 2000 };
            Product pr2 = new Product() { name = "고구마", price = 3000 };
        }
    }
}
