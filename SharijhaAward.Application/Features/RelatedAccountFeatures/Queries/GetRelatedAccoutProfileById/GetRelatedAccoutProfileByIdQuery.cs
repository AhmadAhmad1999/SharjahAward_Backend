using MediatR;
using SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetAllRelatedAccounts;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.ProvidedFromConstants;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetRelatedAccoutProfileById
{
    public class GetRelatedAccoutProfileByIdQuery : IRequest<BaseResponse<GetRelatedAccoutProfileByIdResponse>>
    {
        public int RelatedAccountId { get; set; }
        public ProvidedFormType? Type { get; set; }
        public string? token { get; set; }
        public string? lang { get; set; }
    }
}
