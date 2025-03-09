using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Domain.Entities.ExtraAttachmentModel
{
    public class ExtraAttachmentAttachmentType : AuditableEntity
    {
        public int Id { get; set; }
        public int ExtraAttachmentId { get; set; }
        public ExtraAttachment? ExtraAttachment { get; set; }
        public AttachmentType AttachmentType { get; set; }
    }
}
