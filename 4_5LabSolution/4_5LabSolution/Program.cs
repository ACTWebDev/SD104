using System;
using System.Collections.Generic;

namespace _4_5LabSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the list of scores.
            List<int> scores = new List<int>();
            scores.Add(1200);
            scores.Add(4400);
            scores.Add(3700);
            scores.Add(8900);
            scores.Add(7200);


            //sort the list in default order and print it.
            scores.Sort();
            
            foreach (int s in scores)
            {
                Console.WriteLine(s);
            }

            //Reverse the list order and print it.
            scores.Reverse();

            foreach (int s in scores)
            {
                Console.WriteLine(s);
            }

            //Add a new item to the list
            scores.Add(2400);

            //remove an item from the list
            scores.Remove(4400);

        }
    }
}
