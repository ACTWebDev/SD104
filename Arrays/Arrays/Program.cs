using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 102;
            int num2 = 105;
            int num3 = 108;
            int num4 = 112;
            int num5 = 88;
            int num6 = 12;
            int num7 = 99;
            int num8 = 202;
            int num9 = 999;
            int num10 = 10;

                      
            int[] myArray = { 102, 105, 108, 112, 88, 12, 99, 202, 999, 10 };

            Console.WriteLine(myArray[0]);
                        
            Console.WriteLine(myArray[1]);

            Console.WriteLine(myArray[9]);

            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(myArray.Length);

            int[] bigArray = new int[1000];
            bigArray[600] = 99;

            string[] words = new string[20];
            words[0] = "ice";
            words[1] = "China";
            words[2] = "house";

            object[] mixedBag = { 10, 1, "car", true, 44.2f, 63.999 };
            string car = (string)mixedBag[2];
            car.ToUpper();
                                                                  
            int[] thisArray = new int[5];

        }


    }
}
