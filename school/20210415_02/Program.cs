using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210415_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 필요성: 리스트의 문제점 - 
            // 탐색의 문제점: index 방식, key-value이 아님
            // 그래서 key-value 형식인 Dictionary 사용

            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();

            dic.Add(1, new Monster(1));
            dic[5] = new Monster(5);
        }
    }
}
