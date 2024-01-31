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

namespace SharijhaAward.Infrastructure.EmailSernder
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmail(EmailRequest EmailRequest, string QRCodeImagePath)
        {
            using (var client = new SmtpClient())
            {
                string HtmlBody = EmailRequest.Body;
                //AlternateView HtmlView = AlternateView.CreateAlternateViewFromString(HtmlBody, null, MediaTypeNames.Text.Html);

                //using (var image = SixLabors.ImageSharp.Image.Load(QRCodeImagePath))
                //{
                //    image.Mutate(x => x.Resize(10, 10));
                //    using (var stream = new MemoryStream())
                //    {
                //        image.Save(stream, new PngEncoder());
                //        byte[] resizedImageBytes = stream.ToArray();

                //        LinkedResource linkedImage = new LinkedResource(new MemoryStream(resizedImageBytes), MediaTypeNames.Image.Png);
                //        linkedImage.ContentId = "caligraphyImage";
                //        HtmlView.LinkedResources.Add(linkedImage);
                //    }


                //    //using (var imageStream = new FileStream(ImagePath, FileMode.Open, FileAccess.Read))
                //    //{

                //    //    LinkedResource linkedImage = new LinkedResource("wwwroot/Images/QRCodeForTest Add EventPersonalInvite.png", MediaTypeNames.Image.Svg);
                //    //    linkedImage.ContentId = "caligraphyImage";
                //    //}
                //}

                //using (var imageStream = new FileStream(ImagePath, FileMode.Open, FileAccess.Read))
                //{
                    
                //    AlternateView HtmlView = AlternateView.CreateAlternateViewFromString(HtmlBody, null, MediaTypeNames.Text.Html);
                //    LinkedResource linkedImage = new LinkedResource("wwwroot/Images/QRCodeForTest Add EventPersonalInvite.png", MediaTypeNames.Image.Svg);
                //    linkedImage.ContentId = "caligraphyImage";
                //    HtmlView.LinkedResources.Add(linkedImage);
                //}

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
                    Body = HtmlBody,
                    IsBodyHtml = true
                };

                //Message.AlternateViews.Add(HtmlView);

                Message.To.Add(EmailRequest.ToEmail);

                await client.SendMailAsync(Message);
            }
        }
    }
}
