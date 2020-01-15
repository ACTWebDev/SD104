using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
    class UserAccount
    {
        private string userName;
        private string password;

        private DateTime lastLogonDate;
        private int badPasswordAttempts;
        private bool isLoggedIn;

        FileWriter fileWriter;

        public UserAccount(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        public void Login(string userNameAttempt, string passwordAttempt)
        {            
            
            if (passwordAttempt == password & userNameAttempt == userName)
            {
                isLoggedIn = true;
                fileWriter = new FileWriter();
                DateTime logonTime = DateTime.Now;
                lastLogonDate = logonTime;
                fileWriter.UpdateUserLog(userName, logonTime, true);

            }
            else
            {
                isLoggedIn = false;
                badPasswordAttempts += 1;
                fileWriter = new FileWriter();
                DateTime logonTime = DateTime.Now;
                fileWriter.UpdateUserLog(userName, logonTime, false);


            }

        }

        public void GetUserInfo()
        {
            Console.WriteLine("username = "  + userName);
            Console.WriteLine("last logon = " + lastLogonDate);
            Console.WriteLine("bad password tries = " + badPasswordAttempts);
            Console.WriteLine("is logged in? = " + isLoggedIn );



        }


    }
}
