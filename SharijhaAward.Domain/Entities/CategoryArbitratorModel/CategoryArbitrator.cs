using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryModel;

namespace SharijhaAward.Domain.Entities.CategoryArbitratorModel
{
    public class CategoryArbitrator : AuditableEntity
    {
        public int Id { get; set; }
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
        public Guid ArbitratorId { get; set; }
        public Arbitrator? Arbitrator { get; set; }
    }
}
