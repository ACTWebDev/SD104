using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8
{
    class DancingCat : Cat
    {
        string danceMove;

        public DancingCat(string danceMove, string catName) : base(catName, false)
        {
            this.danceMove = danceMove;
        }

        public void Dance()
        {
            Console.WriteLine(this.name + " dances. She does the " + danceMove);
        }


    }
}
