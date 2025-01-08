using SharijhaAward.Application.Helpers.RecipientsWithViewsHelper;
using SharijhaAward.Application.Models;
using System.Net.Mail;

namespace SharijhaAward.Application.Contract.Infrastructure
{
    public interface IEmailSender
    {
        public Task SendEmail(EmailRequest EmailRequest, AlternateView AlternateView);
        public Task SendEmail(EmailRequest EmailRequest);
        public Task SendEmailForConfirmationCode(EmailRequest EmailRequest);
        public Task<List<string>> SendEmailAsync(List<string> recipients, string subject, string body, AlternateView AlternateView);
        public Task<List<string>> SendEmailAsyncWithDifferentBodies(List<RecipientsWithViews> Recipients, string Subject);
    }
}
