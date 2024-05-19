using MediatR;
using SharijhaAward.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.CancelInterview
{
    public class CancelInterviewCommand : IRequest<BaseResponse<object>>
    {
        public int InterviewId { get; set; }
        [MaxLength]
        public string ArabicReasonOfCanceling { get; set; } = null!;
        [MaxLength]
        public string EnglishReasonOfCanceling { get; set; } = null!;
        public string? lang { get; set; }
    }
}
