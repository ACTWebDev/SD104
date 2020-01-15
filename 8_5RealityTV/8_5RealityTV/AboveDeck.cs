using System;
using System.Collections.Generic;
using System.Text;

namespace _8_5RealityTV
{
    class AboveDeck: Application
    {
        public int yearsExperience;
        public string nationality;

        public AboveDeck(int yearsExperience, string nationality, 
            string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip,
            string phoneNumber, string email) : base(firstName, lastName, dateOfBirth, address, city, state, zip, phoneNumber, email)
        {

            this.yearsExperience = yearsExperience;
            this.nationality = nationality;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Above Deck");
        }
    }
}
