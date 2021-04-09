using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200324_01
{
    class Player
    {
        public int hp;
        public int attack;


        public void playerMove()
        {
            Console.WriteLine("움직임");
        }


        public Player() 
        {
            Console.WriteLine("Player 생성자 호출");
        }
        public Player(int hp)
        {
            this.hp = hp;

            Console.WriteLine("hp 생성자 호출");
        }

        public override string ToString()
        {
            return string.Format($"hp: {this.hp}, attack: {this.attack}");
        }
    }
    class Knight : Player
    {
        int armor;

        public Knight()
        {
            this.armor = 10;
            base.hp = 300;
            Console.WriteLine("Knight 생성자 호출");
        }
        public Knight(int hp, int attack) : base(hp)
        {
            this.attack = attack;
        }
    }
    class Archer : Player
    {
        int arrow;

        public Archer()
        {
            Console.WriteLine("Archer 생성자 호출");
        }
    }
    class Mage : Player
    {
        int mp;

        public Mage()
        {
            Console.WriteLine("Mage 생성자 호출");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight(100, 10);
            Console.WriteLine(knight.ToString());
            knight.playerMove();
        }
    }
}
