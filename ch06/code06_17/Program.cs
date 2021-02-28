using System;

namespace code06_17
{
    class Product
    {
        public static int cnt = 0;
        public int id;
        public string name;
        public int price;

        public Product(string name, int price)
        {
            Product.cnt += 1;
            this.id = cnt;
            this.name = name;
            this.price = price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product productA = new Product("감자", 2000);
            Product productB = new Product("고구마", 3000);

            Console.WriteLine(productA.id + ":" + productA.name);
            Console.WriteLine(productB.id + ":" + productB.name);
            Console.WriteLine(Product.cnt + "개 생성되었습니다.");
        }
    }
}
