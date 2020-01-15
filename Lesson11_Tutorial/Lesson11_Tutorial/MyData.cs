using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11_Tutorial
{
    class MyData
    {
        public string name { get; private set;}
        public int age { get; private set; }
        public string favoriteColor { get; private set; }
        public bool hasPet { get; private set; }
        public string favoriteSport { get; private set; }


        public MyData(string name, int age, string favoriteColor, bool hasPet, string favoriteSport)
        {
            this.name = name;
            this.age = age;
            this.favoriteColor = favoriteColor;
            this.hasPet = hasPet;
            this.favoriteSport = favoriteSport;
        }
    }
}
