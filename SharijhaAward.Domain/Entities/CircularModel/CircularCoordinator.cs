using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.CircularModel
{
    public class CircularCoordinator : AuditableEntity
    {
        public int Id { get; set; }
        public Circular Circular { get; set; } = null!;
        [ForeignKey(nameof(Circular))]
        public int CircularId { get; set; }

        public Coordinator Coordinator { get; set; } = null!;
        [ForeignKey(nameof(Coordinator))]
        public int CoordinatorId { get; set; }
        public bool IsRead { get; set; } = false;
    }
}
