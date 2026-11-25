using MathQuest.enemies;

namespace MathQuest.math
{
    public class DivisionProblem : IMathProblem
    {
        private readonly int _left;
        private readonly int _right;

        public DivisionProblem(DifficultyLevel difficultyLevel)
        {
            var multiplicationProblem = new MultiplicationProblem(difficultyLevel);
            _left = multiplicationProblem.GetSolution();
            _right = multiplicationProblem.Right;
        }


        public int GetSolution()
        {
            return _left / _right;
        }

        public string GetEquationMessage()
        {
            return "What is " + _left + " ÷ " + _right + " = ?";
        }
    }
}