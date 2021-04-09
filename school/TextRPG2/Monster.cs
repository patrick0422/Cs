using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG2
{
    public enum MonsterType
    {
        None = 0,
        Orc = 1,
        Slime = 2,
        Skeleton = 3,
    }
    class Monster : Creature
    {
        protected MonsterType type;

        public Monster(MonsterType type) : base(CreatureType.Monster)
        {
            this.type = type;
        }



        public MonsterType GetMonsterType() { return type; }
    }

    class Orc : Monster
    {
        public Orc() : base(MonsterType.Orc)
        {
            SetInfo(50, 10);
            Console.WriteLine($"오크가 생겼습니다. 체력: {this.GetHp()}, 공격력: {this.GetAttack()}");
        }
    }
    class Slime : Monster
    {
        public Slime() : base(MonsterType.Slime)
        {
            SetInfo(50, 10);
            Console.WriteLine($"슬라임이 생겼습니다. 체력: {this.GetHp()}, 공격력: {this.GetAttack()}");
        }
    }
    class Skeleton : Monster
    {
        public Skeleton() : base(MonsterType.Skeleton)
        {
            SetInfo(50, 10);
            Console.WriteLine($"스켈레톤이 생겼습니다. 체력: {this.GetHp()}, 공격력: {this.GetAttack()}");
        }
    }
}
