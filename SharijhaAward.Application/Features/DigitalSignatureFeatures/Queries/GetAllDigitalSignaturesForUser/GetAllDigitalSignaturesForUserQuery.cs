using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.DigitalSignatureFeatures.Queries.GetAllDigitalSignaturesForUser
{
    public class GetAllDigitalSignaturesForUserQuery : IRequest<BaseResponse<List<GetAllDigitalSignaturesForUserListVM>>>
    {
        public string? lang { get; set; }
        public List<Filter>? filters { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public string? Token { get; set; }
    }
}
