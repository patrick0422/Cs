using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    enum ClassType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3,

        Slime = 11,
        Ork = 12,
        Skeleton = 13,
    }
    
    struct Player
    {
        public int hp;
        public int attack;
    }
    struct Monster
    {
        public int hp;
        public int attack;
    }




    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ClassType choice = ChoiceClass();

                if (choice != ClassType.None)
                {
                    Player player;
                    CreatePlayer(choice, out player);

                    Console.WriteLine($"hp: {player.hp}, attack: {player.attack}");

                    EnterGame(ref player);
                }
            }
        }





        private static void EnterGame(ref Player player)
        {
            Console.WriteLine("\n마을에 접속하였습니다");

            while(true)
            {
                Console.WriteLine("[1] 필드로 간다.");
                Console.WriteLine("[2] 로비로 간다.");

                switch (Console.ReadLine())
                {
                    case "1":
                        EnterField(ref player);
                        break;
                    case "2":
                        return;
                }
            }
        }

        private static void EnterField(ref Player player)
        {
            Console.WriteLine("\n필드에 접속하였습니다.");

            while (true)
            {
                Monster monster;
                CreateMonster(out monster);

                Console.WriteLine("[1] 전투모드 돌입");
                Console.WriteLine("[2] 일정확률로 빤스런");

                switch (Console.ReadLine())
                {
                    case "1": // 전투 시작
                        Fight(ref player, ref monster);
                        break;
                    case "2": // 빤스런 시도
                        if (new Random().Next(0, 100) < 30) // 성공
                        {
                            Console.WriteLine("당신은 도망쳤습니다");
                            return;
                        }
                        else // 실패
                            Console.WriteLine("당신은 싸우기로 했습니다.");
                            Fight(ref player, ref monster);
                        break;
                }
            }
        }

        private static void Fight(ref Player player, ref Monster monster)
        {
            Console.WriteLine("\n전투 시작");
            while (true)
            {
                monster.hp -= player.attack;

                if (monster.hp <= 0)
                {
                    Console.WriteLine($"승리하였습니다. 남은 체력: {player.hp}");
                    
                    
                    return;
                }

                

                player.hp -= monster.attack;
                if (player.hp <= monster.attack)
                {
                    Console.WriteLine($"패배하였습니다.");


                    return;
                }
            }
        }

        private static void CreateMonster(out Monster monster)
        {
            monster.hp = 0; 
            monster.attack = 0;

            switch (new Random().Next(11, 13))
            {
                case (int)ClassType.Slime:
                    monster.hp = 20;
                    monster.attack = 5;
                    Console.WriteLine($"슬라임이 나타났습니다, 체력: {monster.hp}, 공격력: {monster.attack}");
                    break;
                case (int)ClassType.Ork:
                    monster.hp = 40;
                    monster.attack = 3;
                    Console.WriteLine($"오크가 나타났습니다, 체력: {monster.hp}, 공격력: {monster.attack}");
                    break;
                case (int)ClassType.Skeleton:
                    monster.hp = 10;
                    monster.attack = 15;
                    Console.WriteLine($"해골이 나타났습니다, 체력: {monster.hp}, 공격력: {monster.attack}");
                    break;
            }
        }

        private static void CreatePlayer(ClassType choice, out Player player)
        {
            player.hp = 0;
            player.attack = 0;

            switch (choice)
            {
                case ClassType.None:
                    break;
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;
            }
        }
            private static ClassType ChoiceClass()
        {
            Console.WriteLine("\n직업을 선택하세요");
            Console.WriteLine("[1]기사");
            Console.WriteLine("[2]궁수");
            Console.WriteLine("[3]법사");

            ClassType choice = ClassType.None;

            switch (Console.ReadLine())
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Archer;
                    break;
                case "3":
                    choice = ClassType.Mage;
                    break;
            }

            return choice;
        }
    }
}