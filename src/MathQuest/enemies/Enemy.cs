using System;
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

            _hp = DifficultyLevel switch
            {
                DifficultyLevel.Easy => 5,
                DifficultyLevel.Medium => 10,
                DifficultyLevel.Hard => 15,
                _ => throw new ArgumentOutOfRangeException()
            };
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