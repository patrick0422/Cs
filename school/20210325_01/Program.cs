using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210325_01
{
    class Player
    {
        protected int hp;
        protected int attack;

        // virtual 적어야 override 가능
        public virtual void Move()
        {
            Console.WriteLine("플레이어 이동");
        }
    }
    class Knight : Player
    {

        // override
        public override void Move()
        {
            Console.WriteLine("Knight 움직임");
        }
    }
    class Mage : Player
    {

        // sealed = 오버라이딩 막음
        public sealed override void Move()
        {
            Console.WriteLine("Knight 움직임");
        }
    }
    class SuperMage : Mage
    {
        public override void Move()
        {
            Console.WriteLine("이동해");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mage mage = new Mage();

            EnterGame(mage);
        }

        private static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }

        private static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }

        private static void EnterGame(Player player)
        {
            // is = bool type
            if (player is Mage)
            {
                Mage mage2 = (Mage)player;
                Console.WriteLine("변환완료");
            }

            // as = 안되면 null 값 들어감

            Mage magee = (player as Mage);
            if (magee != null)
            {
                Console.WriteLine("as 통한 변환 완료");
            }

        }
    }
}
