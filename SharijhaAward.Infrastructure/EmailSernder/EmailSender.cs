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
using Microsoft.Extensions.Configuration;
using MailKit.Security;
using SharijhaAward.Domain.Entities.ContactUsModels;
using SharijhaAward.Application.Helpers.RecipientsWithViewsHelper;
using PdfSharpCore.Pdf;
using SelectPdf;

namespace SharijhaAward.Infrastructure.EmailSernder
{
    public class EmailSender : IEmailSender
    {
        private IConfiguration _Configuration;
        private const int BatchSize = 10; // Number of recipients to process in each batch
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
                //client.EnableSsl = bool.Parse(_Configuration.GetSection("SMTP:EnableSsl").Value!);
                client.EnableSsl = true;

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
                //client.EnableSsl = bool.Parse(_Configuration.GetSection("SMTP:EnableSsl").Value!);
                client.EnableSsl = true;

                MailMessage Message = new MailMessage
                {
                    From = new MailAddress(SenderEmail),
                    Subject = EmailRequest.Subject,
                    IsBodyHtml = true
                };
                // Message.AlternateViews.Add(AlternateView);
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
                //client.EnableSsl = bool.Parse(_Configuration.GetSection("SMTP:EnableSsl").Value!);
                client.EnableSsl = true;

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
        private List<List<string>> SplitRecipientsIntoBatches(List<string> recipients)
        {
            return recipients
                .Select((value, index) => new { value, index })
                .GroupBy(x => x.index / BatchSize)
                .Select(x => x.Select(v => v.value).ToList())
                .ToList();
        }
        private List<List<RecipientsWithViews>> SplitRecipientsIntoBatches(List<RecipientsWithViews> recipients)
        {
            return recipients
                .Select((value, index) => new { value, index })
                .GroupBy(x => x.index / BatchSize)
                .Select(x => x.Select(v => v.value).ToList())
                .ToList();
        }
        public async Task<List<string>> SendEmailAsync(List<string> recipients, string subject, string body, AlternateView AlternateView)
        {
            try
            {
                string senderEmail = _Configuration.GetSection("SMTP:SenderEmail").Value!;
                string password = _Configuration.GetSection("SMTP:Password").Value!;
                string host = _Configuration.GetSection("SMTP:Host").Value!;
                int.TryParse(_Configuration.GetSection("SMTP:Port").Value, out int port);

                string htmlBody = body;
                NetworkCredential credentials = new NetworkCredential
                {
                    UserName = senderEmail,
                    Password = password
                };

                var batches = SplitRecipientsIntoBatches(recipients);

                List<string> invalidEmails = new List<string>();

                await Task.Run(() =>
                {
                    Parallel.ForEach(batches, batch =>
                    {
                        using (var client = new SmtpClient())
                        {
                            client.Credentials = credentials;
                            client.Host = host;
                            client.Port = port;
                            //client.EnableSsl = bool.Parse(_Configuration.GetSection("SMTP:EnableSsl").Value!);
                            client.EnableSsl = true;

                            foreach (var recipient in batch)
                            {
                                try
                                {
                                    MailMessage message = new MailMessage
                                    {
                                        From = new MailAddress(senderEmail),
                                        Subject = subject,
                                        IsBodyHtml = true,
                                        Body = body
                                    };

                                    message.AlternateViews.Add(AlternateView);

                                    message.To.Add(recipient);
                                    client.Send(message);
                                }
                                catch (SmtpException)
                                {
                                    throw;
                                }
                                catch (Exception)
                                {
                                    invalidEmails.Add(recipient);
                                }
                            }
                        }
                    });
                });

                return invalidEmails;
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public async Task<List<string>> SendEmailAsyncWithDifferentBodies(List<RecipientsWithViews> Recipients, string Subject)
        {
            try
            {
                string SenderEmail = _Configuration.GetSection("SMTP:SenderEmail").Value!;
                string Password = _Configuration.GetSection("SMTP:Password").Value!;
                string Host = _Configuration.GetSection("SMTP:Host").Value!;
                int.TryParse(_Configuration.GetSection("SMTP:Port").Value, out int Port);

                NetworkCredential Credentials = new NetworkCredential
                {
                    UserName = SenderEmail,
                    Password = Password
                };

                List<List<RecipientsWithViews>> Batches = SplitRecipientsIntoBatches(Recipients);

                List<string> InvalidEmails = new List<string>();

                await Task.Run(() =>
                {
                    Parallel.ForEach(Batches, Batch =>
                    {
                        using (var Client = new SmtpClient())
                        {
                            Client.Credentials = Credentials;
                            Client.Host = Host;
                            Client.Port = Port;
                            Client.EnableSsl = true;

                            foreach (RecipientsWithViews Recipient in Batch)
                            {
                                try
                                {
                                    // Generate PDF from HTML
                                    byte[] pdfData = GeneratePdfFromHtml(Recipient.Body);

                                    MailMessage Message = new MailMessage
                                    {
                                        From = new MailAddress(SenderEmail),
                                        Subject = Subject,
                                        IsBodyHtml = false, // Plain text body
                                        Body = "Please find the attached PDF for details."
                                    };
                                    //MailMessage Message = new MailMessage
                                    //{
                                    //    From = new MailAddress(SenderEmail),
                                    //    Subject = Subject,
                                    //    IsBodyHtml = true,
                                    //    Body = Recipient.Body
                                    //};

                                    // Attach the PDF
                                    MemoryStream pdfStream = new MemoryStream(pdfData);
                                    Attachment pdfAttachment = new Attachment(pdfStream, "details.pdf", "application/pdf");
                                    Message.Attachments.Add(pdfAttachment);

                                    Message.AlternateViews.Add(Recipient.AlternateView!);

                                    Message.To.Add(Recipient.Recipient);
                                    Client.Send(Message);
                                }
                                catch (SmtpException)
                                {
                                    throw;
                                }
                                catch (Exception)
                                {
                                    InvalidEmails.Add(Recipient.Recipient);
                                }
                            }
                        }
                    });
                });

                return InvalidEmails;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private byte[] GeneratePdfFromHtml(string htmlContent)
        {
            HtmlToPdf oHtmlToPdf = new HtmlToPdf();
            SelectPdf.PdfDocument oPdfDocument = oHtmlToPdf.ConvertHtmlString(htmlContent);

            byte[] pdf = oPdfDocument.Save();
            oPdfDocument.Close();

            return pdf;
        }
    }
}
