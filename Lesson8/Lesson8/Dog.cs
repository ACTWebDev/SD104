using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8
{
    class Dog : Animal
    {
        private string favoriteChewToy;

        public Dog (string name, int numOfLegs, int numOfArms, bool isDangerous, bool isFurry, string favoriteChewToy)
        {

            //stuff from our base class, Animal
            this.name = name;
            this.numOfLegs = numOfLegs;
            this.numOfArms = numOfArms;
            this.isDangerous = isDangerous;
            this.isFurry = isFurry;

            //new stuff only our Dog can do...
            this.favoriteChewToy = favoriteChewToy;
        }

        public void Bark()
        {
            Console.WriteLine("The " + this.GetType() + " goes WOOF WOOF!");

        }

        public override int Sell()
        {
            Console.WriteLine("I love my dog and would never sell it");
            return 0;
        }

    }
}
