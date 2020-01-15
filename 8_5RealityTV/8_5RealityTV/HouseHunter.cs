using System;
using System.Collections.Generic;
using System.Text;

namespace _8_5RealityTV
{
    class HouseHunter: Application
    {
        public string jobTitle;
        public int currentAnnualIncome;
        public int whenBuyingMonths;
        public int bedrooms;
        public int bathrooms;

        public HouseHunter(string jobTitle, int currentIncome, int whenBuying, int bedrooms, int bathrooms,
            string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip,
            string phoneNumber, string email) : base(firstName, lastName, dateOfBirth, address, city, state, zip, phoneNumber, email)
        {

            this.jobTitle = jobTitle;
            this.currentAnnualIncome = currentIncome;
            this.whenBuyingMonths = whenBuying;
            this.bedrooms = bedrooms;
            this.bathrooms = bathrooms;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Dream House Hunters");
        }
    }
}
