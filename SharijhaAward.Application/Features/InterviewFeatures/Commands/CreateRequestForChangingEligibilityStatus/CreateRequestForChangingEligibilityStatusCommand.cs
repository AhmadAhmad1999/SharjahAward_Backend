using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.CreateRequestForChangingEligibilityStatus
{
    public class CreateRequestForChangingEligibilityStatusCommand : IRequest<BaseResponse<object>>
    {
        public int ProvidedFormId { get; set; }
        public string? Note { get; set; }
        public string? Token { get; set; }
        public string? lang { get; set; }
    }
}
