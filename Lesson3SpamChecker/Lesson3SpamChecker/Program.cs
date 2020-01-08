using System;

namespace Lesson3SpamChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string blackListWord = "viagra";
            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("The message is spam");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("The message is not spam.");
            }
        }
    }
}
