using System;

namespace MathQuest.io
{
    public class ConsoleIo
    {
        public bool GetYesNo()
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
            return unparsedAnswer is "n" or "N" or "no" or "No";
        }


        private bool IsYes(string? unparsedAnswer)
        {
            return unparsedAnswer is "y" or "Y" or "yes" or "Yes";
        }

        public int GetInt()
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

        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}