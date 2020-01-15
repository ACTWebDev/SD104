using System;
using System.Collections.Generic;
using System.Text;

namespace _8_5RealityTV
{
    class Application
    {
        public string firstName;
        public string lastName;
        public string dateOfBirth;
        public string address;
        public string city;
        public string state;
        public int zip;
        public string phoneNumber;
        public string email;
        public bool isSubmitted;
        public bool isAccepted;

        public Application(string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip,
            string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
            isSubmitted = false;
            isAccepted = false;

        }


        public void Submit()
        {
            isSubmitted = true;
            Console.WriteLine("Application has been submitted");
        }

        public virtual void Accept()
        {
            isAccepted = true;
            Console.WriteLine("Application Accepted");
        }
    }
}
