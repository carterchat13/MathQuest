using MathQuest.math;

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

        private DifficultyLevel DifficultyLevel { get; }

        public string Name { get; }

        public IMathProblem GenerateMathProblem()
        {
            return new MathProblemFactory().CreateMathProblem(DifficultyLevel);
        }

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