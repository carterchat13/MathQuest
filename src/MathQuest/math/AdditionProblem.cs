using MathQuest.enemies;

namespace MathQuest.math
{
    public class AdditionProblem : IMathProblem
    {
        private readonly int _left;
        private readonly int _right;

        public AdditionProblem(DifficultyLevel difficultyLevel)
        {
            MathProblemUtils.GetLeftRight(difficultyLevel, out _left, out _right);
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