namespace _20210319_01
{
    internal class Knight
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

        public Knight() { System.Console.WriteLine("생성 완료"); }
        public Knight(int hp, int attack)
        {
            this.hp = hp; this.attack = attack;
        }
    }
}