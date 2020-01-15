using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
    class SimpleClass
    {

        public SimpleClass() { }


        //Static Polymorphism , Method Overloading
        public int Add(int a, int b)
        {
            int results = a + b;
            Console.WriteLine(results);
            return results;
        }
        public int Add(int a, int b, int c)
        {
            int results = a + b + c;
            Console.WriteLine(results);
            return results;
        }
        public string Add(string a, string b)
        {
            string results = a + " " + b;
            Console.WriteLine(results);
            return results;
        }
    }
}
