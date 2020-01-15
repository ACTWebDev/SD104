using System;

namespace ValueVsReference
{
    class Program
    {


        public void MyFirstMethod()
        {
            Console.WriteLine("I will execute each time MyFirstMethod is called");
            Console.WriteLine("I don't return any output.");
        }

        public int WhatIsTwoPlusTwo()
        {
            Console.WriteLine("I will execute each time MyFirstMethod is called");
            Console.WriteLine("I'll return an integer value.");
            int two = 2;
            return two + two;
        }

        public int Subtract(int number1, int number2)
        {
            Console.WriteLine("I will execute each time MyFirstMethod is called");
            Console.WriteLine("I'll return an integer value.");
            Console.WriteLine("I require that you provide two numbers in order to do my job.");
            return number1 - number2;
        }



        //Passing By Value
        static public int AddThree(int someNumber)
        {
            someNumber = + 3;
            return someNumber;
            
        }

        //Passing By Reference
        static public void AddOne(SomeClass objectToChange)
        {
            objectToChange.myNumber += 1;

        }

        static void Main(string[] args)
        {
            int myNum = 1;
            int newNumber = AddThree(myNum);
            myNum = AddThree(myNum);
            Console.WriteLine(myNum);
            Console.WriteLine(newNumber);

            SomeClass someClass = new SomeClass();
            AddOne(someClass);
            Console.WriteLine(someClass.myNumber);
        }
    }
}
