using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Domain.Entities.TermsAndConditionsModel
{
    public class TermAndConditionAttachmentType : AuditableEntity
    {
        public int Id { get; set; }
        public int TermAndConditionId { get; set; }
        public TermAndCondition? TermAndCondition { get; set; }
        public AttachmentType? AttachmentType { get; set; }
    }
}
