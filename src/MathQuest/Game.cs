using System;
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
                Console.Write("Would you like to play again? y/n: ");
                var yesNo = _io.GetYesNo();


                if (yesNo)
                {
                    PlayRound();
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    break;
                    // Exits the loop and stops the program
                }
            }
        }

        private void PlayRound()
        {
            var rnd = new Random();

            var left = rnd.Next(0, 100);
            var right = rnd.Next(0, 100);
            Console.WriteLine("What is " + left + " + " + right + " = ?");
            var answer = left + right;
            var userAnswer = _io.GetInt();

            if (userAnswer == answer)
                Console.WriteLine("Correct!");
            else
                Console.WriteLine("Incorrect.");
        }
    }
}