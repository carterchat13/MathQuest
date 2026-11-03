namespace MathQuest.enemies

{
    public class Enemy
    {
        private int _hp = 2;

        public Enemy(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void DealDamage(int damage)
        {
            _hp -= damage;
        }

        public bool IsAlive()
        {
            return _hp > 0;
        }
    }
}