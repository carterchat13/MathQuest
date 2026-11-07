namespace MathQuest.enemies

{
    public class Enemy
    {
        private int _hp;

        public Enemy(string name, DifficultyLevel difficultyLevel)
        {
            Name = name;
            DifficultyLevel = difficultyLevel;
            if (DifficultyLevel == DifficultyLevel.Easy)
            {
                _hp = 5;
            }
            else if (DifficultyLevel == DifficultyLevel.Medium)
            {
                _hp = 10;
            }
            else if (DifficultyLevel == DifficultyLevel.Hard)
            {
                _hp = 15;
            }
        }

        public DifficultyLevel DifficultyLevel { get; }


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