
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextRPG2
{
    public enum GameMode
    {
        None,
        Lobby,
        Town,
        Field,
    }
    class Game
    {
        private Player player;
        private Monster monster;

        private GameMode mode = GameMode.Lobby;

        public void Process()
        {
            switch (mode)
            {
                case GameMode.None:
                    break;
                case GameMode.Lobby:
                    ProcessLobby();
                    break;
                case GameMode.Town:
                    ProcessTown();
                    break;
                case GameMode.Field:
                    ProcessField();
                    break;
                default:
                    break;
            }
        }

        private void ProcessField()
        {
            Console.WriteLine($"필드에 입장하였습니다. 당신의 체력: {player.GetHp()}");

            CreateMonster();

            Console.WriteLine("[1] 싸우기");
            Console.WriteLine("[2] 일정 확률로 마을로 도망");
            switch (Console.ReadLine())
            {
                case "1":
                    Fight();
                    break;
                case "2":
                    if (new Random().Next(1, 100) < 30)
                    {
                        mode = GameMode.Town;
                        Console.WriteLine("당신은 도망쳤습니다.");
                    }
                    else
                    {
                        Console.WriteLine("당신은 도망치지 못했습니다.");
                        Fight();
                    }
                    break;
            }
        }

        private void CreateMonster()
        {
            switch (new Random().Next(1, 3))
            {
                case 1:
                    monster = new Orc();
                    break;
                case 2:
                    monster = new Slime();
                    break;
                case 3:
                    monster = new Skeleton();
                    break;
            }
        }

        private void Fight()
        {
            Console.WriteLine("전투 시작");

            while (true)
            {
                Thread.Sleep(300);
                monster.OnDamage(player.GetAttack());
                Console.WriteLine($"플레이어의 공격으로 몬스터의 hp는 {monster.GetHp()}가 되었습니다.\n");
                if (monster.isDead())
                {
                    Console.WriteLine($"적이 죽었습니다. 당신의 남은 체력: {player.GetHp()}\n");
                    mode = GameMode.Town;
                    return;
                }

                Thread.Sleep(300);
                player.OnDamage(monster.GetAttack());
                Console.WriteLine($"몬스터의 공격으로 당신의 hp는 {player.GetHp()}가 되었습니다.\n");
                if (player.isDead())
                {
                    Console.WriteLine("당신은 죽었습니다.");
                    mode = GameMode.Lobby;
                    return;
                }
            }
        }

        private void ProcessTown()
        {
            Console.WriteLine("마을에 입장하였습니다.");
            Console.WriteLine("[1] 필드로 가기");
            Console.WriteLine("[2] 로비로 가기");
            switch (Console.ReadLine()) 
            {
                case "1":
                    mode = GameMode.Field;
                    break;
                case "2":
                    mode = GameMode.Lobby;
                    break;
            }
        }

        public void ProcessLobby()
        {
            Console.WriteLine("직업을 선택하세요: ");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            switch (Console.ReadLine())
            {
                case "1":
                    player = new Knight();
                    break;
                case "2":
                    player = new Archer();
                    break;
                case "3":
                    player = new Mage();
                    break;
                default:
                    player = new Player(PlayerType.None);
                    break;
            }


            Console.WriteLine($"직업 타입: {player.GetPlayerType()}");
            mode = GameMode.Town;
        }
    }
}
