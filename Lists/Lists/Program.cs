using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArrayList al = new ArrayList();
            al.Add("Apples");
            al.Add("Bananas");
            al.Add("Cherries");

            foreach (string item in al)
            {
                Console.WriteLine(item);
            }

            int x = 0;

            while (x < 10)
            {
                Console.WriteLine("Value of x: {0}", x);

                x++;
            }

            int z = 0;

            do
            {
                Console.WriteLine("Value of i: {0}", z);

                z++;

            } while (z < 10);



            List<string> myList = new List<string>();
            myList.Add("Apples");
            myList.Add("Bananas");
            myList.Add("Cherries");

            foreach (string item in myList)
            {
                Console.WriteLine(item);
            }


            int[] thisArray = {4,6,2,12,9,8,5,3,4,9,12};
            for (int i = 0; i < thisArray.Length; i++)
            {
                Console.WriteLine(thisArray[i]);
            }


            int counter = 1;

            while (counter < 10)
            {
                
                if (counter == 5 || counter == 6)
                {
                    counter++;
                    continue;
                }

                Console.WriteLine("Value of the counter: {0}", counter);
                
                counter++;
            }


            int youAreGoingToBeHereAWhile = 1;

            while (youAreGoingToBeHereAWhile < 9000000)
            {
                Console.WriteLine("Value of the counter: {0}", youAreGoingToBeHereAWhile);
                Thread.Sleep(6000);
                Console.WriteLine("Look's like you are going to be here a while. Do you want to continue running the loop?");
                string getMeOutOfHere = Console.ReadLine();

                if (getMeOutOfHere == "N")
                {
                    Console.WriteLine("Ok, shutting down the loop early.");
                    break;
                }

                youAreGoingToBeHereAWhile++;
            }

        }
    }
}
