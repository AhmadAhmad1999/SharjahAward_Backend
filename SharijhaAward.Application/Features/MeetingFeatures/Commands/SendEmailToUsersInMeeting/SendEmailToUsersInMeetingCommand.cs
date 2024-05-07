using MediatR;
using SharijhaAward.Application.Features.MeetingFeatures.Commands.CreateMeeting;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.SendEmailToUsersInMeeting
{
    public class SendEmailToUsersInMeetingCommand : IRequest<BaseResponse<object>>
    {
        public int MeetingId { get; set; }
        public List<CreateMeetingUserDto> UsersInfo { get; set; } = new List<CreateMeetingUserDto>();
        public string? lang { get; set; }
    }
}
