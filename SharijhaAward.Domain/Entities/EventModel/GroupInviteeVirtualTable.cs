namespace SharijhaAward.Domain.Entities.EventModel
{
    public class GroupInviteeVirtualTable
    {
        public int Id { get; set; }
        public int UniqueIntegerId { get; set; }
        public int NumberOfExpectedAttendance { get; set; }
        public int NumberOfActualAttendance { get; set; }
        public bool IsAttend { get; set; }
    }
}
