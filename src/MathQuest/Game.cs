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
            for (var i = 0; i < 4; i++) FightEnemy();
            _io.Print("All enemies defeated!");
            _io.Print("Goodbye.");
        }


        private void FightEnemy()
        {
            var enemy = new Enemy("Guy");
            // print "An enemy approaches!" or something like that. Maybe put like enemy.name or enemy.taunt fields for fun?
            _io.Print(enemy.Name + " approaches!");
            _io.Print("Solve equation to attack.");
            while (enemy.IsAlive())
            {
                var problem = _problemFactory.CreateMathProblem();
                var message = problem.GetEquationMessage();
                _io.Print(message);
                var userAnswer = _io.GetInt();
                if (userAnswer == problem.GetSolution())
                {
                    _io.Print("Correct!");
                    _io.Print("1 Damage Dealt to " + enemy.Name);
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