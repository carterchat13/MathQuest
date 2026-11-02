using System;

namespace MathQuest
{
    public class Game
    {
        public void Run()
        {
            PlayRound();


            while (true)
            {
                Console.Write("Would you like to play again? y/n: ");
                var yesNo = ParseYesNo();


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
            var userAnswer = ParseAnswer();

            if (userAnswer == answer)
                Console.WriteLine("Correct!");
            else
                Console.WriteLine("Incorrect.");
        }

        private bool ParseYesNo()
        {
            var unparsedAnswer = Console.ReadLine();
            var isYes = IsYes(unparsedAnswer);
            var isNo = IsNo(unparsedAnswer);
            var isValid = isYes || isNo;


            while (!isValid)
            {
                Console.WriteLine("Invalid input. Please type 'y' or 'n'");
                unparsedAnswer = Console.ReadLine();
                isYes = IsYes(unparsedAnswer);
                isNo = IsNo(unparsedAnswer);

                isValid = isYes || isNo;
            }

            return isYes;
        }

        private bool IsNo(string? unparsedAnswer)
        {
            return unparsedAnswer == "n" || unparsedAnswer == "N" || unparsedAnswer == "no" ||
                   unparsedAnswer == "No";
        }


        private bool IsYes(string? unparsedAnswer)
        {
            return unparsedAnswer == "y" || unparsedAnswer == "Y" || unparsedAnswer == "yes" ||
                   unparsedAnswer == "Yes";
        }

        private int ParseAnswer()
        {
            var unparsedAnswer = Console.ReadLine();
            var isValid = int.TryParse(unparsedAnswer, out var userAnswer);
            while (!isValid)
            {
                Console.WriteLine("Please enter a valid integer.");
                unparsedAnswer = Console.ReadLine();
                isValid = int.TryParse(unparsedAnswer, out userAnswer);
            }

            return userAnswer;
        }
    }
}