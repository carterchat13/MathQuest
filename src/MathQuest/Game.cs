using MathQuest.enemies;
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
            FightEnemy();


            while (true)
            {
                _io.Print("Would you like to play again? y/n: ");
                var yesNo = _io.GetYesNo();


                if (yesNo)
                {
                    FightEnemy();
                }
                else
                {
                    _io.Print("Goodbye!");
                    break;
                    // Exits the loop and stops the program
                }
            }
        }

        private void FightEnemy()
        {
            var enemy = new Enemy("dur");
            // print "An enemy approaches!" or something like that. Maybe put like enemy.name or enemy.taunt fileds for fon?
            _io.Print(enemy.Name + " approaches!");

            while (enemy.IsAlive())
            {
                var problem = _problemFactory.CreateMathProblem();
                var message = problem.GetEquationMessage();
                _io.Print(message);
                var userAnswer = _io.GetInt();
                if (userAnswer == problem.GetSolution())
                {
                    _io.Print("Correct!");
                    enemy.DealDamage(1);
                }
                else
                {
                    _io.Print("Incorrect.");
                }
            }

            _io.Print("Enemy defeated!");
        }
    }
}