using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _20210305_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            string b = a.ToString();
            WriteLine(b);

            float c = 3.14f;
            string d = c.ToString();
            WriteLine(d);

            string e = "123456";
            int f = Convert.ToInt32(e);
            WriteLine(f);

            string g = "1.2345";
            float h = float.Parse(g);
            WriteLine(h);
        }
    }
}
