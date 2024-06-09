using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.EducationalEntityModel;

namespace SharijhaAward.Domain.Entities.CategoryModel
{
    public class CategoryEducationalEntity : AuditableEntity
    {
        public int Id { get; set; }
        public int EducationalEntityId { get; set; }
        public EducationalEntity? EducationalEntity { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
