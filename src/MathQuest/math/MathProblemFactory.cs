using System;

namespace MathQuest.math
{
    public class MathProblemFactory
    {
        public IMathProblem CreateMathProblem()
        {
            var mode = Random.Shared.Next(1, 3);
            if (mode == 1) return new AdditionProblem();
            return new SubtractionProblem();
        }
    }
}