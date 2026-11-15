using System;
using MathQuest.math;

namespace MathQuest.enemies
{
    public class Enemy
    {
        private int _hp;

        public Enemy(string name, DifficultyLevel difficultyLevel, MathProblemType mathProblemType)
        {
            MathProblemType = mathProblemType;
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
        private MathProblemType MathProblemType { get; }
        public string Name { get; }

        public IMathProblem GenerateMathProblem()
        {
            if (MathProblemType == MathProblemType.Addition)
            {
                return new AdditionProblem(DifficultyLevel);
            }

            return new SubtractionProblem(DifficultyLevel);
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