namespace _20210319_01
{
    internal class Mage
    {
        public int hp;
        public int attack;

        public void Move()
        {
            System.Console.WriteLine("꿈틀");
        }
        public void Kill()
        {
            this.hp = 0;
        }

        public Mage()
        {
        }
        public Mage(int hp, int attack)
        {
            this.hp = hp; this.attack = attack;
        }
    }
}