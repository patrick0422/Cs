using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG2
{
    public enum PlayerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3,
    }

    class Player : Creature
    {
        protected PlayerType type;

        public Player(PlayerType type) : base(CreatureType.Player)
        {
            this.type = type;
        }

        

        public PlayerType GetPlayerType() { return type; }
    }



    // 이름 | 체력 공격력
    // 기사 : 100  10
    // 궁수 : 75   12
    // 법사 : 50   15

    // 기사
    class Knight : Player
    {
        public Knight() : base(PlayerType.Knight)
        {
            SetInfo(100, 10);
        }
    }

    // 궁수
    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer)
        {
            SetInfo(75, 12);
        }
    }

    //법사
    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            SetInfo(50, 15);
        }
    }
}
