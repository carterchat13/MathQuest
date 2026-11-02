using MathQuest.io;

namespace MathQuest
{
    public class Game
    {
        private readonly ConsoleIO _io = new();

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
            var problem = new MathProblem();
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