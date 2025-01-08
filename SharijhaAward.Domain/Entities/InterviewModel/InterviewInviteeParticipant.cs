using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.InterviewModel
{
    public class InterviewInviteeParticipant : AuditableEntity
    {
        public int Id { get; set; }

        public int InterviewInviteeId { get; set; }
        public InterviewInvitee? InterviewInvitee { get; set; }

        public string? ExternalUserEmail { get; set; }

        public int? SubscriberId { get; set; }
        public User? Subscriber { get; set; }

        public int? ArbitratorId { get; set; }
        public Arbitrator? Arbitrator { get; set; }

        public bool CanImplementTheInterview { get; set; } = true;
        public string? ReasoneForNotImplementing { get; set; }
    }
}
