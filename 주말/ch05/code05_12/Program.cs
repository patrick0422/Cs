using System;

namespace code05_12
{
    class Product
    {
        public string name = "default";
        public int price = 1000;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            product.name = "감자";
            product.price = 2000;

            Console.WriteLine(product.name +" : " + product.price + "원");
        }
    }
}
