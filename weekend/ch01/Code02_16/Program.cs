using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code02_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = "안녕하세요";
            for(int i = 0; i < st.Length; i++)
            {
                Console.WriteLine(st[i] + "\t" + "안녕하세요"[i]);
            }
        }
    }
}
