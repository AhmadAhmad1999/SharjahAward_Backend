using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;

namespace SharijhaAward.Domain.Entities.TrainingWorkshopAttachmentModel
{
    public class TrainingWorkshopAttachment : AuditableEntity
    {
        public int Id { get; set; }
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;
        public string AttachementPath { get; set; } = string.Empty;
        public int SizeOfAttachmentInKB { get; set; }
        public int TrainingWorkshopId { get; set; }
        public TrainingWorkshop TrainingWorkshop { get; set; } = null!;
    }
}
