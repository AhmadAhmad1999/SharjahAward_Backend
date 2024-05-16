using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;

namespace SharijhaAward.Domain.Entities.InterviewModel
{
    public class InterviewCategory : AuditableEntity
    {
        public int Id { get; set; }
        public int InterviewId { get; set; }
        public Interview? Interview { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
