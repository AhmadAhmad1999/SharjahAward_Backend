using MediatR;
using SharijhaAward.Application.Features.AppVersioningFeatures.Query.GetLastAppVersion;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AppVersioningFeatures.Query.GetAllLastVersionsForAllTypes
{
    public class GetAllLastVersionsForAllTypesQuery : IRequest<BaseResponse<List<GetAllLastVersionsForAllTypesListVM>>>
    {
        public string? lang { get; set; }
    }
}
