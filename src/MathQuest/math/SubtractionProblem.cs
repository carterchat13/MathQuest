using System;
using MathQuest.enemies;

namespace MathQuest.math
{
    public class SubtractionProblem : IMathProblem
    {
        private readonly int _left;
        private readonly int _right;

        public SubtractionProblem(DifficultyLevel difficultyLevel)
        {
            int rangeLeft;
            int rangeRight;
            if (difficultyLevel == DifficultyLevel.Easy)
            {
                rangeLeft = 10;
                rangeRight = 10;
            }
            else if (difficultyLevel == DifficultyLevel.Medium)
            {
                rangeLeft = 50;
                rangeRight = 50;
            }
            else
            {
                //Hard Difficulty
                rangeLeft = 100;
                rangeRight = 100;
            }


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