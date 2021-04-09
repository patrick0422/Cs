using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210319_01
{
    class Program
    { 
        static void Main(string[] args)
        {
            Knight knight = new Knight();

            knight.hp = 20;
            knight.attack = 5;
            knight.Move();

            Console.WriteLine($"Knight hp : {knight.hp}");
            Console.WriteLine($"Knight attack : {knight.attack}");


            Mage mage = new Mage(300, 1001);

            Console.WriteLine($"Mage hp : {mage.hp}");
            Console.WriteLine($"Mage attack : {mage.attack}");
        }
    }
}