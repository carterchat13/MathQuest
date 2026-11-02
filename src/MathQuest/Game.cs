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
            var rnd = new Random();

            var left = rnd.Next(0, 100);
            var right = rnd.Next(0, 100);
            _io.Print("What is " + left + " + " + right + " = ?");
            var answer = left + right;
            var userAnswer = _io.GetInt();

            if (userAnswer == answer)
                _io.Print("Correct!");
            else
                _io.Print("Incorrect.");
        }
    }
}