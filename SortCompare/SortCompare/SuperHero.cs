using System;
using System.Collections.Generic;
using System.Text;

namespace SortCompare
{
    class SuperHero
    {

        public string name { get; private set; }
        public int strength { get; private set; }
        public int speed { get; private set; }
        public int intelligence { get; private set; }


        public SuperHero (string name, int strength, int speed, int intelligence)
        {
            this.name = name;
            this.strength = strength;
            this.speed = speed;
            this.intelligence = intelligence;
        }
    }
}
