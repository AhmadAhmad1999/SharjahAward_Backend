using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.EducationalInstitutionModel
{
    public class EducationalInstitution : AuditableEntity
    {
        public Guid Id { get; set; }
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;

        public EducationalEntity EducationalEntity { get; set; } = null!;

        [ForeignKey(nameof(EducationalEntity))]
        public Guid EducationalEntityId { get; set; }
    }
}
