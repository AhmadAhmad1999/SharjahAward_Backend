using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ContactUsModels;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.WebSiteResponseModel
{
    public class WebSiteResponse : AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;

        public int EmailMessageId { get; set; }
        public EmailMessage? EmailMessage { get; set; }
        
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
