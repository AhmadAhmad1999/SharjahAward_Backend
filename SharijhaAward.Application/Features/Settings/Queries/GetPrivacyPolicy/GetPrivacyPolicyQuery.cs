using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Queries.GetPrivacyPolicy
{
    public class GetPrivacyPolicyQuery : IRequest<BaseResponse<GetPrivacyPolicyDto>>
    {
        public string Slug { get; set; } = null!;
        public string? lang { get; set; }
    }
}
