using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lesson9
{
    class FileWriter
    {
        private const string userLogFile = "C:\\weblogs\\userlog.txt";
            

        public void ExampleWriteFile()
        {
            string fileName = "C:\\weblogs\\log1.txt";
            string data = "Print this info to a log. \n";
            File.AppendAllText(fileName, data);

        }

        public void UpdateUserLog(string userName, DateTime logonTime, bool wasLoginSuccessful)
        {
            if (wasLoginSuccessful == true)
            {
                string logEntry = userName + " successfully logged in at " + logonTime + "\n";
                File.AppendAllText(userLogFile, logEntry);
            }
            else
            {
                string logEntry = userName + " entered a bad password at " + logonTime + "\n";
                File.AppendAllText(userLogFile, logEntry);

            }
        }

        public void CreateHTML(StringBuilder htmlText)
        {
            File.WriteAllText("C:\\weblogs\\myHTML.html", htmlText.ToString());
        }

    }
}
