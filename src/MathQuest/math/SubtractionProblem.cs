using System;

namespace MathQuest.math
{
    public class SubtractionProblem : IMathProblem
    {
        private readonly int _left;
        private readonly int _right;

        public SubtractionProblem(int rangeLeft, int rangeRight)
        {
            var rnd = new Random();
            _left = rnd.Next(0, rangeLeft);
            _right = rnd.Next(0, rangeRight);
        }

        public string GetEquationMessage()
        {
            return "What is " + _left + " - " + _right + " = ?";
        }

        public int GetSolution()
        {
            var solution = _left - _right;
            return solution;
        }
    }
}