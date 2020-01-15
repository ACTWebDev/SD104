using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8
{
    abstract class Animal
    {
        protected string name;
        protected int numOfLegs;
        protected int numOfArms;
        protected bool isDangerous;
        protected bool isFurry;


        public void Sleep() {
            Console.WriteLine("The " + this.GetType() + " goes to sleep.");
        }

        public void Eat()
        {
            Console.WriteLine("The " + this.GetType()  + " goes to eats.");
        }

        public virtual void Breath() {
            Console.WriteLine("The animal breathes through it's nose!");
        }

        public abstract int Sell();
    }
}
