using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.CircularModel
{
    public class Circular : AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string CircularText { get; set; } = string.Empty;
        //public List<CircularAttachment>? CircularAttachments { get; set; }
        //public List<CircularCoordinator>? CircularCoordinators { get; set; }
        //public List<CircularArbitrator>? CircularArbitrators { get; set; }
        //public List<CircularChairman>? CircularChairmans { get; set; }
    }
}
