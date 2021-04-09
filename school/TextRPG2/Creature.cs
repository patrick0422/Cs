using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG2
{
    public enum CreatureType
    {
        None,
        Player,
        Monster,
    }
    class Creature
    {
        protected CreatureType type = CreatureType.None;
        protected int hp;
        protected int attack;
        public Creature(CreatureType type)
        {
            this.type = type;
        }

        public void SetInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }

        public CreatureType GetCreatureType() { return type; }
        public int GetHp() { return hp; }
        public int GetAttack() { return attack; }

        public bool isDead() { return hp <= 0; }

        public void OnDamage(int damage)
        {
            hp -= damage;
            if (hp < 0)
            {
                hp = 0;
            }
        }
    }
}
