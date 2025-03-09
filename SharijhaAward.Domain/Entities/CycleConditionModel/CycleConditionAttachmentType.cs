using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Domain.Entities.CycleConditionModel
{
    public class CycleConditionAttachmentType : AuditableEntity
    {
        public int Id { get; set; }
        public int CycleConditionId { get; set; }
        public CycleCondition? CycleCondition { get; set; }
        public AttachmentType? AttachmentType { get; set; }
    }
}
