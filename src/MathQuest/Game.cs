using MathQuest.enemies;
using MathQuest.io;

namespace MathQuest
{
    public class Game
    {
        private readonly ConsoleIo _io = new();

        public void Run()
        {
            var enemies = new[]
            {
                new Enemy("Guy", DifficultyLevel.Easy),
                new Enemy("Fly", DifficultyLevel.Medium),
                new Enemy("Tie", DifficultyLevel.Medium),
                new Enemy("Die", DifficultyLevel.Hard)
            };
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
                var problem = enemy.GenerateMathProblem();

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