using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAnalysisByVirtualTableForSectionId
{
    public class GetAnalysisByVirtualTableForSectionIdQuery : IRequest<BaseResponse<List<GetAnalysisByVirtualTableForSectionIdListVM>>>
    {
        public int VirtualTableForSectionId { get; set; }
        public string? lang { get; set; }
    }
}
