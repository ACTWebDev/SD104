using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8
{


    class MemberShip
    {
        public enum Level
        {

            Basic,
            Preimum,
            Lifetime
        }

        public Plan plan;
        public Level level;

        public MemberShip()
        {
            plan = new Plan();
        }

        public void ChangeMembership(MemberShip.Level newLevel)
        {
            level = newLevel;
        }

    }
}
