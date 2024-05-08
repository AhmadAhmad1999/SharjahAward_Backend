using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.CancelMeeting
{
    public class CancelMeetingCommand : IRequest<BaseResponse<object>>
    {
        public int MeetingId { get; set; }
        public string ArabicReasonOfCanceling { get; set; } = null!;
        public string EnglishReasonOfCanceling { get; set; } = null!;
        public string? lang { get; set; }
    }
}
