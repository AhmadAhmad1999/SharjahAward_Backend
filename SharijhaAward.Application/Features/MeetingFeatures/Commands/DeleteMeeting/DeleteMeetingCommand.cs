using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.DeleteMeeting
{
    public class DeleteMeetingCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
