using MathQuest.io;
using MathQuest.math;

namespace MathQuest
{
    public class Game
    {
        private readonly ConsoleIO _io = new();
        private readonly MathProblemFactory _problemFactory = new();

        public void Run()
        {
            PlayRound();


            while (true)
            {
                _io.Print("Would you like to play again? y/n: ");
                var yesNo = _io.GetYesNo();


                if (yesNo)
                {
                    PlayRound();
                }
                else
                {
                    _io.Print("Goodbye!");
                    break;
                    // Exits the loop and stops the program
                }
            }
        }

        private void PlayRound()
        {
            var problem = _problemFactory.CreateMathProblem();
            var message = problem.GetEquationMessage();
            _io.Print(message);
            var userAnswer = _io.GetInt();
            if (userAnswer == problem.GetSolution())
                _io.Print("Correct!");
            else
                _io.Print("Incorrect.");
        }
    }
}