using System;
using System.Net.Mail;

namespace MailExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("my_email_account@gmail.com");
            mail.To.Add("someone@hotmail.com");
            mail.Subject = "C# Mail";
            mail.Body = "This is for testing SMTP mail from C# application.";

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("my_email_account@gmail.com", "PASSWORD1234");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
