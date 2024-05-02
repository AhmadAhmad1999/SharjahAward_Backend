using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AppVersioningFeatures.Query.GetAllAppVersions
{
    public class GetAllAppVersionsQuery : IRequest<BaseResponse<List<GetAllAppVersionsListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
