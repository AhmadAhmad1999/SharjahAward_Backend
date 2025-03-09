using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.CircularModel
{
    public class CircularArbitrator : AuditableEntity
    {
        public int Id { get; set; }
        public Circular Circular { get; set; } = null!;
        [ForeignKey(nameof(Circular))]
        public int CircularId { get; set; }

        public Arbitrator Arbitrator { get; set; } = null!;
        [ForeignKey(nameof(Arbitrator))]
        public int ArbitratorId { get; set; }
        public bool IsRead { get; set; } = false;
    }
}
