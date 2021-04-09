using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210322_01
{
    class Knight
    {
        private static int count = 0;

        private int hp;
        private int attack;
        private int id;

        public Knight() 
        {
            Console.WriteLine("기본생성자 호출");
        }
        public Knight(int hp) : this()
        {
            Console.WriteLine("hp 생성자 호출");
            this.hp = hp;
        }
        public Knight(int hp, int attack) : this(hp)
        {
            this.attack = attack;
            Console.WriteLine("attack 생성자 호출");
        }

        public int getHp() { return hp; }
        public int getAttack() { return attack; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight(100, 12);
            Console.WriteLine($"{knight.getHp()}, {knight.getAttack()}");
        }
    }
}
