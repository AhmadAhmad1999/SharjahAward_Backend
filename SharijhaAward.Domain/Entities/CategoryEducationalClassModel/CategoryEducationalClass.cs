using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.EducationalClassModel;

namespace SharijhaAward.Domain.Entities.CategoryEducationalClassModel
{
    public class CategoryEducationalClass : AuditableEntity
    {
        public int Id { get; set; }
        public Guid EducationalClassId { get; set; }
        public EducationalClass? EducationalClass { get; set; }
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
        public int NumberOfExpectedWinners { get; set; }
    }
}
