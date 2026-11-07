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
            var enemies = new[]
            {
                new Enemy("Guy", DifficultyLevel.Easy),
                new Enemy("Fly", DifficultyLevel.Medium),
                new Enemy("Tie", DifficultyLevel.Medium),
                new Enemy("Die", DifficultyLevel.Hard)
            };

            // creeate array of enemies, then foreach through each of them, passing enemy in to FightEnemy(enemy);
            foreach (var enemy in enemies)
            {
                FightEnemy(enemy);
            }

            _io.Print("All enemies defeated!");
            _io.Print("Goodbye.");
        }


        private void FightEnemy(Enemy enemy)
        {
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