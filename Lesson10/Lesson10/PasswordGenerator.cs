using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
    class PasswordGenerator
    {
        string characterPool = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        int passwordLength = 8;

        public PasswordGenerator(){}

        public string CreatePassword()
        {
            Random rnd = new Random();
            StringBuilder password = new StringBuilder();
            for (int i = 0; i < passwordLength; i++)
            {
                int characterIndex = rnd.Next(0, characterPool.Length);
                password.Append(characterPool.Substring(characterIndex, 1));
            }
            return password.ToString();       
        }
    }
}
