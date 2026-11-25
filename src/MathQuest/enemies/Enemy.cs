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
                _ => throw new Exception("No such difficulty level.")
            };
        }

        private DifficultyLevel DifficultyLevel { get; }
        private MathProblemType MathProblemType { get; }
        public string Name { get; }

        public IMathProblem GenerateMathProblem()
        {
            return MathProblemType switch
            {
                MathProblemType.Addition => new AdditionProblem(DifficultyLevel),
                MathProblemType.Subtraction => new SubtractionProblem(DifficultyLevel),
                MathProblemType.Multiplication => new MultiplicationProblem(DifficultyLevel),
                MathProblemType.Division => new DivisionProblem(DifficultyLevel),
                _ => throw new Exception("No such math problem type.")
            };
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