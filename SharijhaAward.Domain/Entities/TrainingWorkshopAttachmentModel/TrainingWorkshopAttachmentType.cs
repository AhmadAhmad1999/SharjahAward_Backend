using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Domain.Entities.TrainingWorkshopAttachmentModel
{
    public class TrainingWorkshopAttachmentType : AuditableEntity
    {
        public int Id { get; set; }
        public int TrainingWorkshopAttachmentId { get; set; }
        public TrainingWorkshopAttachment? TrainingWorkshopAttachment { get; set; }
        public AttachmentType AttachmentType { get; set; }
    }
}
