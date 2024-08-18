using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.AppVersioningFeatures.Query.GetAllAppVersions
{
    public class GetAllAppVersionsQuery : IRequest<BaseResponse<List<GetAllAppVersionsListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public AppType? AppType { get; set; }
        public List<Filter>? filters { get; set; }
    }
}
