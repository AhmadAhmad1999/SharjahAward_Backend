using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.MeetingModel;

namespace SharijhaAward.Domain.Entities.MeetingCategoryModel
{
    public class MeetingCategory : AuditableEntity
    {
        public int Id { get; set; }
        public int MeetingId { get; set; }
        public Meeting? Meeting { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
