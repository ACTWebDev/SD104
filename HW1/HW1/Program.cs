using System;

namespace Solution_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1; //input one
            int number2; //input two

            Console.WriteLine("Enter a value for the first number:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for the second number:");
            number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 + number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);

            result = number1 - number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);


            result = number1 * number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);

            double results2 = (double)number1 / (double)number2;  //divide 
            double results3 = number1 % number2;  //reminder (left over after division)
            Console.WriteLine("The answer is:"); 
            Console.WriteLine(results2);  //speficy to print the results to screen as a double.
            Console.WriteLine(results3);




        }
    }
}
