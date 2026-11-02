using System;

namespace MathQuest.math
{
    public class AdditionProblem : IMathProblem
    {
        private readonly int _left;
        private readonly int _right;

        public AdditionProblem()
        {
            var rnd = new Random();
            _left = rnd.Next(0, 100);
            _right = rnd.Next(0, 100);
        }

        public string GetEquationMessage()
        {
            return "What is " + _left + " + " + _right + " = ?";
        }

        public int GetSolution()
        {
            var solution = _left + _right;
            return solution;
        }
    }
}