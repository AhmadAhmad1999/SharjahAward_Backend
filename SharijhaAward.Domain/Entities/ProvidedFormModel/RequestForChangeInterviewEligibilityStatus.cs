using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.ProvidedFormModel
{
    public class RequestForChangeInterviewEligibilityStatus : AuditableEntity
    {
        public int Id { get; set; }
        public int ProvidedFormId { get; set; }
        public ProvidedForm? ProvidedForm { get; set; }
        public int RequestedById { get; set; }
        public User? RequestedBy { get; set; }
        public string? Note { get; set; }
    }
}
