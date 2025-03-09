using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Domain.Entities.CriterionModel
{
    public class CriterionAttachmentType : AuditableEntity
    {
        public int Id { get; set; }
        public int CriterionId { get; set; }
        public Criterion? Criterion { get; set; }
        public AttachmentType? AttachmentType { get; set; }
    }
}
