using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AppVersioningFeatures.Query.GetLastAppVersion
{
    public class GetLastAppVersionQuery : IRequest<BaseResponse<GetLastAppVersionDto>>
    {
        public string? lang { get; set; }
    }
}
