using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.AppVersioningFeatures.Query.GetAllAppVersions
{
    public class GetAllAppVersionsQuery : IRequest<BaseResponse<List<GetAllAppVersionsListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; }
        public int perPage { get; set; }
        public AppType? AppType { get; set; }
    }
}
