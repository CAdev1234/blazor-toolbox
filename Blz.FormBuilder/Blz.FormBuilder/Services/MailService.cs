using Microsoft.Data.SqlClient.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Blz.FormBuilder.Services
{
    public class MailService
    {
        readonly string sender = "wangliewang311@gmail.com";
        readonly string gmail_password = "Mynameisfenglong4233";
        public void SendMailWithSMTP(string receiver, string subject, string emailLink)
        {
            Console.WriteLine("receiver=" + receiver);
            Console.WriteLine("emailLink=" + emailLink);
            try
            {
                using MailMessage mail = new MailMessage();
                mail.From = new MailAddress(sender);
                mail.To.Add(receiver);
                mail.Subject = subject;
                mail.Body = $"<h1>{emailLink}</h1>";
                mail.IsBodyHtml = true;

                using SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential(sender, gmail_password);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                Console.WriteLine("Email sent");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
