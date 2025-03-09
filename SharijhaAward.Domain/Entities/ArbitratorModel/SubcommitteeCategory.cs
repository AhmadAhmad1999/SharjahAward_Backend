using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;

namespace SharijhaAward.Domain.Entities.ArbitratorModel
{
    public class SubcommitteeCategory : AuditableEntity
    {
        public int Id { get; set; }
        public int ArbitratorId { get; set; }
        public Arbitrator? Arbitrator { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
