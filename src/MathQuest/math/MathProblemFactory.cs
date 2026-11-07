using System;

namespace MathQuest.math
{
    public class MathProblemFactory
    {
        public IMathProblem CreateMathProblem(int rangeLeft, int rangeRight)
        {
            var mode = Random.Shared.Next(1, 3);
            if (mode == 1) return new AdditionProblem(rangeLeft, rangeRight);
            return new SubtractionProblem(rangeLeft, rangeRight);
        }
    }
}