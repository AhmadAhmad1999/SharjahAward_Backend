using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.MeetingModel;

namespace SharijhaAward.Domain.Entities.MeetingUserModel
{
    public class MeetingUser : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int MeetingId { get; set; }
        public Meeting? Meeting { get; set; }
    }
}
