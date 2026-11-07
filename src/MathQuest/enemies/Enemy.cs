using MathQuest.math;

namespace MathQuest.enemies
{
    public class Enemy
    {
        private readonly int _rangeLeft;
        private readonly int _rangeRight;
        private int _hp;

        public Enemy(string name, DifficultyLevel difficultyLevel)
        {
            Name = name;
            DifficultyLevel = difficultyLevel;

            if (DifficultyLevel == DifficultyLevel.Easy)
            {
                _hp = 5;
                _rangeLeft = 10;
                _rangeRight = 10;
            }
            else if (DifficultyLevel == DifficultyLevel.Medium)
            {
                _hp = 10;
                _rangeLeft = 50;
                _rangeRight = 50;
            }
            else if (DifficultyLevel == DifficultyLevel.Hard)
            {
                _hp = 15;
                _rangeLeft = 100;
                _rangeRight = 100;
            }
        }

        public DifficultyLevel DifficultyLevel { get; }

        public string Name { get; }

        public IMathProblem GenerateMathProblem()
        {
            return new MathProblemFactory().CreateMathProblem(_rangeLeft, _rangeRight);
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