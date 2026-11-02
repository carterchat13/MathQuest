using System;

namespace MathQuest
{
    public class Game
    {
        public void Run()
        {
            var rnd = new Random();
            for (var ctr = 1; ctr <= 1; ctr++)
            {
                var left = rnd.Next(0, 100);
                var right = rnd.Next(0, 100);
                Console.WriteLine("What is " + left + " + " + right + " = ?");
                var answer = left + right;

                // Collect an int from the user, repeating until they give a valid int
                // once you have a valid int, check if it is correct and print the appropriate message


                var userAnswer = ParseAnswer();

                if (userAnswer == answer)
                    Console.WriteLine("Correct!");
                else
                    Console.WriteLine("Incorrect.");
            }

            while (true)
            {
                Console.Write("Would you like to play again? y/n: ");
                var yesNo = ParseYesNo();

                //Todo: Find a way to not call runMethod again
                if (yesNo)
                {
                    Run();
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    break;
                    // Exits the loop and stops the program
                }
            }
        }

        private bool ParseYesNo()
        {
            var unparsedAnswer = Console.ReadLine();
            var isYes = unparsedAnswer == "y" || unparsedAnswer == "Y" || unparsedAnswer == "yes" ||
                        unparsedAnswer == "Yes";
            var isNo = unparsedAnswer == "n" || unparsedAnswer == "N" || unparsedAnswer == "no" ||
                       unparsedAnswer == "No";
            var isValid = isYes || isNo;


            while (!isValid)
            {
                Console.WriteLine("Invalid input. Please type 'y' or 'n'");
                unparsedAnswer = Console.ReadLine();
                isYes = unparsedAnswer == "y" || unparsedAnswer == "Y" || unparsedAnswer == "yes" ||
                        unparsedAnswer == "Yes";
                isNo = unparsedAnswer == "n" || unparsedAnswer == "N" || unparsedAnswer == "no" ||
                       unparsedAnswer == "No";
                isValid = isYes || isNo;

                // Executes if all previous conditions are false
            }

            return isYes;
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