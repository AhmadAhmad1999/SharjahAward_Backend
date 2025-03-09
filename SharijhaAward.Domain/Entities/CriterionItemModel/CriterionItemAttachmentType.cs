using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Domain.Entities.CriterionItemModel
{
    public class CriterionItemAttachmentType : AuditableEntity
    {
        public int Id { get; set; }
        public int CriterionItemId { get; set; }
        public CriterionItem? CriterionItem { get; set; }
        public AttachmentType AttachmentType { get; set; }
    }
}
