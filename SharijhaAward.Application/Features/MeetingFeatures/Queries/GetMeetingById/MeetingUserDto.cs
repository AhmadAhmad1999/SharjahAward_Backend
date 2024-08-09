using SharijhaAward.Application.Helpers.EmailValidationHelper;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.MeetingFeatures.Queries.GetMeetingById
{
    public class MeetingUserDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        [EmailValidation]
        public string Email { get; set; } = null!;
    }
}
