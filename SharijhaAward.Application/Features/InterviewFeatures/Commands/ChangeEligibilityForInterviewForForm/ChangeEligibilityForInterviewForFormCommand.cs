using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.ChangeEligibilityForInterviewForForm
{
    public class ChangeEligibilityForInterviewForFormCommand : IRequest<BaseResponse<object>>
    {
        public int ProvidedFormId { get; set; }
        public string? lang { get; set; }
    }
}
