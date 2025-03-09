using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.CircularModel
{
    public class CircularChairman : AuditableEntity
    {
        public int Id { get; set; }
        public Circular Circular { get; set; } = null!;
        [ForeignKey(nameof(Circular))]
        public int CircularId { get; set; }

        public Arbitrator Chairman { get; set; } = null!;
        [ForeignKey(nameof(Chairman))]
        public int ChairmanId { get; set; }
        public bool IsRead { get; set; } = false;
    }
}
