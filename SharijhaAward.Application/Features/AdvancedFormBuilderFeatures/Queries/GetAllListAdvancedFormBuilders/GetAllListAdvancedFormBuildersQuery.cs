using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllListAdvancedFormBuilders
{
    public class GetAllListAdvancedFormBuildersQuery : IRequest<BaseResponse<List<GetAllListAdvancedFormBuildersListVM>>>
    {
        public int SectionId { get; set; }
        public string? lang { get; set; }
    }
}
