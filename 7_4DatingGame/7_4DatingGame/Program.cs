using System;

namespace _7_4DatingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            DatingProfile bob = new DatingProfile("Bob", "Jones", 50, "Male");
            bob.WriteBio("Strong outdoors type");

            DatingProfile susie = new DatingProfile("Susie", "Sue", 45, "Female");
            susie.WriteBio("new to this site");

            bob.SendMessage("Hello Susie", "Want to get some coffee?", susie);
            susie.ReadMessage();
        }
    }
}
