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
            Console.WriteLine("\n20 random numbers from 0 to 100:");
            for (int ctr = 1; ctr <= 20; ctr++)
            {
                Console.WriteLine( rnd.Next(0, 100));
            }
        }
    }
}
