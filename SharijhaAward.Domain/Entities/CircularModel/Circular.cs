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
    public class Circular : AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string CircularText { get; set; } = string.Empty;
        public bool IsRead { get; set; } = false;
        //public List<CircularAttachment>? CircularAttachments { get; set; }
        //public List<CircularCoordinator>? CircularCoordinators { get; set; }
        //public List<CircularArbitrator>? CircularArbitrators { get; set; }
        //public List<CircularChairman>? CircularChairmans { get; set; }
    }
}
