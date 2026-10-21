using System;

namespace MathQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?: ");
            // Makes a string variable that stores the next input from the user
            string userName = Console.ReadLine(); 

            Console.WriteLine($"Hello, {userName}!");

            Random rnd = new Random();
            Console.WriteLine("\nRandom number:");
            for (int ctr = 1; ctr <= 1; ctr++)
            {
                var left = rnd.Next(0, 100);
                var right = rnd.Next(0, 100);
                Console.WriteLine(left + " + " + right + " = ?");
            }


     
        }
    }
    
}
