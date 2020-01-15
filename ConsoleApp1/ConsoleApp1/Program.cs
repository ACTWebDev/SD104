using System;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
            {
            Console.WriteLine("Hello World");
            int myFirstNumber = 19;
            int mySecondNumber = 244;
            Console.WriteLine(myFirstNumber * mySecondNumber);
            string myText = "Some Text";
            Console.WriteLine(myText + mySecondNumber);
            string moreText = "Goes Here";
            Console.WriteLine(myText + moreText);
            string color1, color2;
            color1 = "Yellow";
            color2 = "Red";
            bool isYellow = true;
            bool isGreen = false;
            Console.WriteLine(color1 + isYellow + color2 + isGreen);
            double numbers;
            numbers = mySecondNumber / myFirstNumber;
            Console.WriteLine(numbers);
            numbers = mySecondNumber / (double)myFirstNumber;
            Console.WriteLine(numbers);
            Console.WriteLine("BreakPoint Here");

            string textToNumber = "80473";
            int results = 99 * int.Parse(textToNumber);
            Console.WriteLine(results);

            DateTime rightNow = DateTime.Now;
            Console.WriteLine(rightNow);





        }
    }
}
