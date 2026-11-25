using System;
using MathQuest.enemies;

namespace MathQuest.math
{
    public class MultiplicationProblem : IMathProblem
    {
        public readonly int Right;
        private readonly int _left;

        public MultiplicationProblem(DifficultyLevel difficultyLevel)
        {
            int rangeLeft;
            int rangeRight;
            if (difficultyLevel == DifficultyLevel.Easy)
            {
                rangeLeft = 6;
                rangeRight = 6;
            }
            else if (difficultyLevel == DifficultyLevel.Medium)
            {
                rangeLeft = 8;
                rangeRight = 8;
            }
            else
            {
                //Hard Difficulty
                rangeLeft = 12;
                rangeRight = 12;
            }


            var rnd = new Random();
            _left = rnd.Next(1, rangeLeft);
            Right = rnd.Next(1, rangeRight);
        }

        public string GetEquationMessage()
        {
            return "What is " + _left + " * " + Right + " = ?";
        }

        public int GetSolution()
        {
            var solution = _left * Right;
            return solution;
        }
    }
}