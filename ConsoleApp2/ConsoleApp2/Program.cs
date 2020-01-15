using System;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            string line1 = "myemailaddress@yahoo.com";
            Console.WriteLine(line1.IndexOf("@"));
            //@ occurs at character position 14 

            Console.WriteLine(line1.IndexOf("email"));
            //"email" begins at character position 2 

            Console.WriteLine(line1.IndexOf("Zeus"));
            //"Zeus" doesn't appear in "myemailaddress@yahoo.com".
            //Returns -1


            string line2 = "The cat in the corner can count.";
            line2 = line2.Replace("c", "Z");
            Console.WriteLine(line2);
            //The Zat in the Zorner Zan Zount.


            Console.WriteLine(line2.Length);
            //32 characters long

            Console.WriteLine(line2.Contains("in the"));
            //Returns true because the words appear in the sentence.

            //The Zat in the Zorner Zan Zount.
            string[] words = line2.Split("Z");
            
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }

            //The Zat in the Zorner Zan Zount.
            Console.WriteLine(line2.Substring(4,3));
            //Returns "Zat", the 5th character, 6th, 7th characters.
            //Remeber, the 1st character is "0".

            string line3 = "    TRIM ME DOWN       ";
            Console.WriteLine(line3.Trim());
            //TRIM ME DOWN

            Console.WriteLine(line3.GetType());
            //System.String

            string textToSearch = "This is Sparta!";
            string regex = "[a-z]";
            MatchCollection matchResults = Regex.Matches(textToSearch, regex);

            foreach (Match m in matchResults)
            {
                Console.WriteLine(m);
            }

            textToSearch = "afgkk24679ggZXVFcatcat9970b02dogMaryxxxxbbbb22FHDFISHMOTHERfaskldjflasjfjasdfjzxcvxcEYERTR345262372546vbcvb0000000carTT2356236623732623462366johnxcxcxvbdfsdgvxcvC#00002499xbvvcfgooglecvcvxzvdfgsdjiiruewortuiwerioptunvxn990348590234523907854034sdnskfshwateririweotowyuwerituwreutpwetuwertueryuwertwerutpweurtpuweptnvmxcvnnxcxcxvb";
            regex = "[a-z]at";

            matchResults = Regex.Matches(textToSearch, regex);

            foreach (Match m in matchResults)
            {
                Console.WriteLine(m);
            }









        }
    }
}
