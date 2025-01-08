using System.Net.Mail;

namespace SharijhaAward.Application.Helpers.RecipientsWithViewsHelper
{
    public class RecipientsWithViews
    {
        public string Recipient { get; set; } = null!;
        public string Body { get; set; } = null!;
        public AlternateView AlternateView { get; set; } = null!;
    }
}
