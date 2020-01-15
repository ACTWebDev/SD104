using System;
using System.Collections.Generic;

namespace SortCompare
{
    class Program
    {

        private static bool SearchCondition(int i)
        {
            return i == 10;
        }

        static void Main(string[] args)
        {

            //Sorting an Array.
            int[] numbers = { 8, 9, 2, 20, 1, 5, 3, 10, 7, 6 };
            Array.Sort(numbers);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            //Reversing the Order of the Array
            Array.Reverse(numbers);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

 

            //int searchResult = Array.Find(numbers, SearchCondition);
            int searchResult = Array.Find(numbers, search => search == 10);

            //this code will find the value returned by SearchCondition method
            int results = Array.Find(numbers, SearchCondition);

            //another example
            int result2 = Array.Find(numbers, search => search < 5); //return first value less than 5
            int result3 = Array.Find(numbers, search => search > 6 & search < 8); // return first value greater than 6 and lesss than 8
            Console.WriteLine("SEARCH RESULTS: " + searchResult +  " " + results + " " +  result2 + " " +  result3);

            object myvalue = 20;
            Array.Sort(numbers);
            int bsearchResult = Array.BinarySearch(numbers, myvalue);
            Console.WriteLine("SEARCH RESULTS " + searchResult);
            Console.WriteLine("BINARY SEARCH RESULTS " + bsearchResult);



            DateTime[] dates = { Convert.ToDateTime("2/1/2019"), Convert.ToDateTime("3/1/2017"), Convert.ToDateTime("3/20/2019") };
            Array.Sort(dates);
            foreach (DateTime date in dates)
            {
                Console.WriteLine(date.ToString());
            }

            //Sorting a List
            List<char> myList = new List<char>();
            myList.Add('c');
            myList.Add('a');
            myList.Add('d');
            myList.Add('b');
            myList.Add('e');

            myList.Sort();
            foreach (char item in myList)
            {
                Console.WriteLine(item);
            }

            //Reversing the list
            myList.Reverse();
            foreach (char item in myList)
            {
                Console.WriteLine(item);
            }


            //Creating complex data
            SuperHero superman = new SuperHero("Superman", 10, 9, 5);
            SuperHero batman = new SuperHero("Batman", 3, 2, 7);
            SuperHero flash = new SuperHero("Flash", 6, 10, 4);

            SuperHero[] allSuperHeros = { superman, batman, flash };

            //We need a Comparer to Sort our super heros
            SuperSpeedComparer speedComparer = new SuperSpeedComparer();
            Array.Sort(allSuperHeros, speedComparer);
            Console.WriteLine("\nList of Fastest Heros");


            foreach (SuperHero hero in allSuperHeros)
            {
                Console.WriteLine(hero.name);
            }

            SuperHero fastest = allSuperHeros.GetValue(0) as SuperHero;
            Console.WriteLine("\nThe FASTEST Super Hero is " + fastest.name);

            //We need a Comparer to Sort our super heros
            SuperStrengthComparer strengthComparer = new SuperStrengthComparer();
            Array.Sort(allSuperHeros, strengthComparer);
            Console.WriteLine("\nList of Strongest Heros");


            foreach (SuperHero hero in allSuperHeros)
            {
                Console.WriteLine(hero.name);

            }

            SuperHero strongest = allSuperHeros.GetValue(0) as SuperHero;
            Console.WriteLine("\nThe STRONGEST Super Hero is " + strongest.name );

        }

    }
}
