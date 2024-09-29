using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.ImplementMeeting
{
    public class ImplementMeetingCommand : IRequest<BaseResponse<object>>
    {
        public string? lang { get; set; }
        public int MeetingId { get; set; }
    }
}
