using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.HomePageFeatures.Queries.GetAllHomePageData
{
    public class GetAllHomePageDataQuery : IRequest<BaseResponse<GetAllHomePageDataDto>>
    {
        public int? CycleId { get; set; }
        public string? lang { get; set; }
        public string? Token { get; set; }
    }
}
