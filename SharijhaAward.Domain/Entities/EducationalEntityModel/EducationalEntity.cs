using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CycleModel;

namespace SharijhaAward.Domain.Entities.EducationalEntityModel
{
    public class EducationalEntity : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public int CycleId { get; set; }
        public Cycle? Cycle { get; set; }
    }
}
