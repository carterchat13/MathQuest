using System;
using MathQuest.enemies;

namespace MathQuest.math
{
    public class MathProblemFactory
    {
        public IMathProblem CreateMathProblem(DifficultyLevel difficultyLevel)
        {
            var mode = Random.Shared.Next(1, 3);
            if (mode == 1) return new AdditionProblem(difficultyLevel);
            return new SubtractionProblem(difficultyLevel);
        }
    }
}