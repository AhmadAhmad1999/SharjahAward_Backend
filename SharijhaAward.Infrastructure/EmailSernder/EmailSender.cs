using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using MimeKit.Utils;
using System.Net.Mime;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Formats.Png;
using Microsoft.Extensions.Configuration;

namespace SharijhaAward.Infrastructure.EmailSernder
{
    public class EmailSender : IEmailSender
    {
        private IConfiguration _Configuration;
        public EmailSender(IConfiguration Configuration)
        {
            _Configuration = Configuration;
        }
        public async Task SendEmail(EmailRequest EmailRequest, AlternateView AlternateView)
        {
            using (var client = new SmtpClient())
            {
                string SenderEmail = _Configuration.GetSection("SMTP:SenderEmail").Value!;
                string Password = _Configuration.GetSection("SMTP:Password").Value!;
                string Host = _Configuration.GetSection("SMTP:Host").Value!;
                int.TryParse(_Configuration.GetSection("SMTP:Port").Value, out int Port);

                string HtmlBody = EmailRequest.Body;
                NetworkCredential Credentials = new NetworkCredential
                {
                    UserName = SenderEmail,
                    Password = Password
                };

                client.Credentials = Credentials;
                client.Host = Host;
                client.Port = Port;
                client.EnableSsl = bool.Parse(_Configuration.GetSection("SMTP:EnableSsl").Value!);

                MailMessage Message = new MailMessage
                {
                    From = new MailAddress(SenderEmail),
                    Subject = EmailRequest.Subject,
                    IsBodyHtml = true
                };

                Message.AlternateViews.Add(AlternateView);
                Message.To.Add(EmailRequest.ToEmail);
                try
                {
                    await client.SendMailAsync(Message);
                }
                catch (SmtpException)
                {
                    throw;
                }
            }
        }
        public async Task SendEmail(EmailRequest EmailRequest)
        {
            using (var client = new SmtpClient())
            {
                string SenderEmail = _Configuration.GetSection("SMTP:SenderEmail").Value!;
                string Password = _Configuration.GetSection("SMTP:Password").Value!;
                string Host = _Configuration.GetSection("SMTP:Host").Value!;
                int.TryParse(_Configuration.GetSection("SMTP:Port").Value, out int Port);

                string HtmlBody = EmailRequest.Body;
                NetworkCredential Credentials = new NetworkCredential
                {
                    UserName = SenderEmail,
                    Password = Password
                };

                client.Credentials = Credentials;
                client.Host = Host;
                client.Port = Port;
                client.EnableSsl = bool.Parse(_Configuration.GetSection("SMTP:EnableSsl").Value!);

                MailMessage Message = new MailMessage
                {
                    From = new MailAddress(SenderEmail),
                    Subject = EmailRequest.Subject,
                    IsBodyHtml = true
                };

                Message.To.Add(EmailRequest.ToEmail);
                try
                {
                    await client.SendMailAsync(Message);
                }
                catch (SmtpException)
                {
                    throw;
                }
            }
        }
        public async Task SendEmailForConfirmationCode(EmailRequest EmailRequest)
        {
            using (var client = new SmtpClient())
            {
                string SenderEmail = _Configuration.GetSection("SMTP:SenderEmail").Value!;
                string Password = _Configuration.GetSection("SMTP:Password").Value!;
                string Host = _Configuration.GetSection("SMTP:Host").Value!;
                int.TryParse(_Configuration.GetSection("SMTP:Port").Value, out int Port);

                string HtmlBody = EmailRequest.Body;
                NetworkCredential Credentials = new NetworkCredential
                {
                    UserName = SenderEmail,
                    Password = Password
                };

                client.Credentials = Credentials;
                client.Host = Host;
                client.Port = Port;
                client.EnableSsl = bool.Parse(_Configuration.GetSection("SMTP:EnableSsl").Value!);

                MailMessage Message = new MailMessage
                {
                    From = new MailAddress(SenderEmail),
                    Subject = EmailRequest.Subject,
                    IsBodyHtml = true,
                    Body = EmailRequest.Body
                };

                Message.To.Add(EmailRequest.ToEmail);
                try
                {
                    await client.SendMailAsync(Message);
                }
                catch (SmtpException)
                {
                    throw;
                }
            }
        }
    }
}
