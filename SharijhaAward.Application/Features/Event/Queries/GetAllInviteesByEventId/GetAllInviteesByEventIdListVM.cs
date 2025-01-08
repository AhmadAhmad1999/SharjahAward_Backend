namespace SharijhaAward.Application.Features.Event.Queries.GetAllInviteesByEventId
{
    public class GetAllInviteesByEventIdListVM
    {
        public int Id { get; set; }
        public int UniqueIntegerId { get; set; }
        public int NumberOfExpectedAttendance { get; set; }
        public int NumberOfActualAttendance { get; set; }
        public bool IsAttend { get; set; }
        public string Email { get; set; } = null!;
    }
}
