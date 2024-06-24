using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
