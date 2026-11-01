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


                var userAnswer = parseAnswer();

                if (userAnswer == answer)
                    Console.WriteLine("Correct!");
                else
                    Console.WriteLine("Incorrect.");
            }
            
            while (true)
{
    Console.Write("Would you like to play again? y/n: ");
    // Makes a variable that stores the next input from the user
    var playTime = Console.ReadLine();

    if (playTime == "y" || playTime == "Y" || playTime == "yes" || playTime == "Yes")
    {
        Run();
        break; // Exits the prompt loop after running the game again
    }
    else if (playTime == "n" || playTime == "N" || playTime == "no" || playTime == "No")
    {
        Console.WriteLine("Goodbye!");
        break; // Exits the loop and stops the program
    }
    else
    {
        // Executes if all previous conditions are false
        Console.WriteLine("Invalid input. Please type 'y' or 'n'");
    }
}

        }

        private int parseAnswer()
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