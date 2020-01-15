using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6OOP
{
    class Animal
    {
        private int legs { get; set; }
        private int arms { get; set; }
        private string type { get; set; }
        private string name { get; set; }
        private bool isDangerous { get; set; }


        public Animal(int legs, int arms, string type, string name, bool isDangerous)
        {
            this.legs = legs;
            this.arms = arms;
            this.type = type;
            this.name = name;
            this.isDangerous = isDangerous;

        }

        public void ShowDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Type of Animal: " + type);
            Console.WriteLine("Number of Arms: " + arms);
            Console.WriteLine("Number of Legs: " + legs);
            Console.WriteLine("Is Dangerous? " + isDangerous);


        }

        public void SendToObedienceSchool()
        {
            if (isDangerous)
            {
                isDangerous = false;
                Console.WriteLine(name + " is a good " + type + " now!");
            }
            else
            {
                Console.WriteLine("But " + name + " isn't dangerous!");
            }
            

        }

        public void Evolve(int newArms, int newLegs)
        {
            arms = newArms;
            legs = newLegs;
            type = "Something Else!";
        }
    }
}
