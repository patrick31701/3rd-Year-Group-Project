using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

using BusinessEntities;

namespace BusinessLayer
{
    public class Emailing
    {
        public static void sendEmail(string customerEmail)
        {
            string htmlString = getEmailStructure();
            Email(customerEmail, htmlString);
        }

        public static void sendPromoEmail(string htmlString, string subject, string customerEmail)
        {
            EmailPromo(customerEmail, subject, htmlString);
        }

        public static void Email(string customerEmail, string htmlString)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                smtp.UseDefaultCredentials = false;
                message.From = new MailAddress("healthyfoodstorepromo@gmail.com");
                message.To.Add(new MailAddress(customerEmail));
                message.Subject = "Store Registration";
                message.IsBodyHtml = true;
                message.Body = htmlString;

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("healthyfoodstorepromo@gmail.com", "HealthyStore_4");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.Send(message);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void EmailPromo(string customerEmail, string subject, string htmlString)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                smtp.UseDefaultCredentials = false;
                message.From = new MailAddress("healthyfoodstorepromo@gmail.com");
                message.To.Add(new MailAddress(customerEmail));
                message.Subject = subject;
                message.IsBodyHtml = true;
                message.Body = htmlString;

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("healthyfoodstorepromo@gmail.com", "HealthyStore_4");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.Send(message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static string getEmailStructure()
        {
            string email = "";
                email += "<div><h1>Healthy Food Store</h1></div>";
                email += "<h2>Registration</h2>";
                email += "<p>Welcome to the Healthy Food Store. We are so happy to see join the team !!</p>";
                email += "<p>From us you will get promotional letters and coupons codes for stuff that you buy in the store.</p>";
            return email;
        }

        public static string getPromoEmailStructure(string title, string body, string coupon)
        {
            string email = "";
            email += $"<h1 style=\"margin-left: 1em;\">{title}</h1>";
            email += $"<p style=\"margin-left: 1em;\">{body}</p>";
            email += "<br>";
            email += $"<p style=\"margin-left: 1em;\">Coupon Code: {coupon}</p>";
            email += $"<p style=\"margin-left: 1em;\">From, your favourite</p>";
            email += $"<p style=\"margin-left: 1em;\">Healthy Food Store Team</p>";
            return email;
        }

    }
}
