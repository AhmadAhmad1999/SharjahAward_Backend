using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.MeetingFeatures.Queries.GetMeetingById
{
    public class MeetingUserDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = null!;
    }
}
