using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.TermsAndConditions.Attacments.Queries.ReviewSpecialConditionAttachments
{
    public class ReviewSpecialConditionAttachmentsQuery
        : IRequest<BaseResponse<List<SpecialTermAndConditionListVM>>>
    {
        public string lang { get; set; } = string.Empty;
        public string token { get; set; } = string.Empty;
        public int formId { get; set; }
    }
}
