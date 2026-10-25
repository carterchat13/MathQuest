using System;

namespace MathQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?: ");
            // Makes a string variable that stores the next input from the user
            var userName = Console.ReadLine(); 

            Console.WriteLine($"Hello, {userName}!");

            Random rnd = new Random();
            Console.WriteLine("\nRandom number:");
            for (int ctr = 1; ctr <= 1; ctr++)
            {
                var left = rnd.Next(0, 100);
                var right = rnd.Next(0, 100);
                Console.WriteLine("What is " + left + " + " + right + " = ?");
                var answer = left += right;

                // Collect an int from the user, repeating until they give a valid int
                // once you have a valid int, check if it is correct and print the appropriate message

             
                var unparsedAnswer = Console.ReadLine();
                bool isValid = int.TryParse(unparsedAnswer, out int userAnswer);
                while(isValid == false)
                {
                    Console.WriteLine("Please enter a valid integer.");
                    unparsedAnswer = Console.ReadLine();
                    isValid = int.TryParse(unparsedAnswer, out userAnswer);
                }
                if(userAnswer == answer)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }
            }

        }
    }
    
}
