using SharijhaAward.Application.Helpers.EmailValidationHelper;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.CreateMeeting
{
    public class CreateMeetingUserDto
    {
        public string Name { get; set; } = null!;
        [EmailValidation]
        public string Email { get; set; } = null!;
        //public int MeetingId { get; set; }
    }
}
