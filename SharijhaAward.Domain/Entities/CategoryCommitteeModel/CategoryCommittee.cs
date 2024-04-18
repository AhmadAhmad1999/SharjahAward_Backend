using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CommitteeModel;

namespace SharijhaAward.Domain.Entities.CategoryCommitteeModel
{
    public class CategoryCommittee : AuditableEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public int CommitteeId { get; set; }
        public Committee? Committee { get; set; }
    }
}