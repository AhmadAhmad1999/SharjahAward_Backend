using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.AppVersioningFeatures.Query.GetLastAppVersion
{
    public class GetLastAppVersionQuery : IRequest<BaseResponse<GetLastAppVersionDto>>
    {
        public string? lang { get; set; }
        public AppType AppType { get; set; }
    }
}
