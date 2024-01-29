using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Infrastructure.EmailSernder
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmail(EmailRequest EmailRequest)
        {
            using (var client = new SmtpClient())
            {
                NetworkCredential Credentials = new NetworkCredential
                {
                    UserName = "no-reply@warshatec.com",
                    Password = "QAZwsx!@1212"
                };

                client.Credentials = Credentials;
                client.Host = "mail.warshatec.com";
                client.Port = 587;
                client.EnableSsl = false;

                MailMessage Message = new MailMessage
                {
                    From = new MailAddress("no-reply@warshatec.com"),
                    Subject = EmailRequest.Subject,
                    Body = EmailRequest.Body,
                    IsBodyHtml = true
                };

                Message.To.Add(EmailRequest.ToEmail);
                await client.SendMailAsync(Message);
            }
        }
    }
}
