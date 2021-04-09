using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200312_03
{
    enum PlayerClass
    {
        NONE = -1,
        기사 = 1,
        궁수 = 2,
        마법사 = 3
    }
    struct Player
    {
        public PlayerClass playerClass;
        public int hp, attack;
    }


    enum MonsterClass
    {
        슬라임 = 1,
        고블린 = 2,
        치킨 = 3,
        멍멍이 = 4
    }
    struct Monster
    {
        public MonsterClass monsterClass;
        public int hp, attack;
    }
    






    class Program
    {
        static void Main(string[] args)
        {
            Player player;

            player = CreatePlayer(ChooseClass());

            EnterGame(ref player);
        }





        

        
        private static PlayerClass ChooseClass()
        {
            string choice;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("직업을 선택하세요");
                Console.WriteLine("[1] 기사\r\n[2] 궁수\r\n[3] 마법사");

                Console.Write(">>");
                choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        return PlayerClass.기사;
                    case "2":
                        return PlayerClass.궁수;
                    case "3":
                        return PlayerClass.마법사;

                }
            }
        }
        private static Player CreatePlayer(PlayerClass playerClass)
        {
            Player player;
            switch (playerClass)
            {
                case PlayerClass.기사:
                    player.playerClass = PlayerClass.기사;
                    player.hp = 100; player.attack = 10;
                    break;
                case PlayerClass.궁수:
                    player.playerClass = PlayerClass.궁수;
                    player.hp = 50; player.attack = 20;
                    break;
                case PlayerClass.마법사:
                    player.playerClass = PlayerClass.마법사;
                    player.hp = 60; player.attack = 17;
                    break;
                default:
                    player.playerClass = PlayerClass.NONE;
                    player.hp = -1; player.attack = -1;
                    break;
            }

            Console.WriteLine($"당신은 {player.playerClass}가 되었습니다.\n체력: {player.hp}, 공격력: {player.attack}\n");
            return player;
        }
        
        private static Monster CreateMonster(MonsterClass monsterClass)
        {
            Monster monster;
            monster.monsterClass = monsterClass;
            switch (monsterClass)
            {
                case MonsterClass.슬라임:
                    monster.hp = 60; monster.attack = 10;
                    break;
                case MonsterClass.고블린:
                    monster.hp = 30; monster.attack = 5;
                    break;
                case MonsterClass.치킨:
                    monster.hp = 200; monster.attack = 1;
                    break;
                case MonsterClass.멍멍이:
                    monster.hp = 10; monster.attack = 45;
                    break;
                default:
                    monster.hp = 10; monster.attack = 1;
                    break;
            }

            Console.WriteLine($"{monster.monsterClass}(이)가 나타났습니다.\n체력: {monster.hp}, 공격력: {monster.attack}\n");
            return monster;
        }


        static void EnterGame(ref Player player)
        {
            while (true)
            {
                Console.WriteLine("마을에 접속했습니다.");
                Console.WriteLine("[1] 필드로 간다.");
                Console.WriteLine("[2] 로비로 간다.");
                Console.Write(">>");

                String input = Console.ReadLine();

                switch (input)
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
            while(true)
            {
                Console.Clear();
                Console.WriteLine("필드에 접속했습니다.");

                Monster monster = CreateMonster((MonsterClass)new Random().Next(1, 4));
                Console.WriteLine("[1] 전투모드 돌입");
                Console.WriteLine("[2] 일정확률로 마을로 도망");
                Console.Write(">>");
                switch (Console.ReadLine())
                {
                    case "1":
                        BattleMode(ref player, ref monster);
                        break;
                    case "2":
                        if (new Random().Next(0, 100) < 33)
                        {
                            Console.WriteLine("당신은 빤스런했습니다.");
                            return;
                        }
                        else
                        { 
                            Console.WriteLine("당신은 상남자처럼 맞서 싸우기로 했습니다.");
                            BattleMode(ref player, ref monster);
                        }
                        break;
                }
            }
        }

        private static void BattleMode(ref Player player, ref Monster monster)
        {
            Console.Clear();
            Console.WriteLine("\n==== 전투 시작 ====\n");
            while (true)
            {
                monster.hp -= player.attack;
                Console.WriteLine($"{player.playerClass}의 공격으로 {monster.monsterClass}의 체력은 {monster.hp}가 되었습니다.");
                if (monster.hp <= 0)
                {
                    Console.WriteLine($"승리하였습니다. (남은 체력 : {player.hp})");
                    Console.WriteLine("\n==== 전투 종료 ====\n");
                    Console.ReadKey();
                    return;
                }
                player.hp -= monster.attack;
                Console.WriteLine($"{monster.monsterClass}의 공격으로 {player.playerClass}의 체력은 {player.hp}가 되었습니다.");
                if (player.hp <= 0)
                {
                    Console.WriteLine("사망했습니다.");
                    Console.WriteLine("\n==== 전투 종료 ====\n");
                    Console.ReadKey();
                    return;
                }
            }
        }
    }
}
