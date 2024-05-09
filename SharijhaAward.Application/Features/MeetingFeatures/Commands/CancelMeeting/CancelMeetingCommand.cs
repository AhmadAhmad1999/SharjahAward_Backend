using MediatR;
using SharijhaAward.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.CancelMeeting
{
    public class CancelMeetingCommand : IRequest<BaseResponse<object>>
    {
        public int MeetingId { get; set; }
        [MaxLength]
        public string ArabicReasonOfCanceling { get; set; } = null!;
        [MaxLength]
        public string EnglishReasonOfCanceling { get; set; } = null!;
        public string? lang { get; set; }
    }
}
