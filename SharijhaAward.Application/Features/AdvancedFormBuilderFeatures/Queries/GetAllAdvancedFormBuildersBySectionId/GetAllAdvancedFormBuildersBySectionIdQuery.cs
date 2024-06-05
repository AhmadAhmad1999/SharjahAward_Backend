using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllAdvancedFormBuildersBySectionId
{
    public class GetAllAdvancedFormBuildersBySectionIdQuery : IRequest<BaseResponse<List<AdvancedFormBuilderListVM>>>
    {
        public int SectionId { get; set; }
        public string? lang { get; set; }
        public int page { get; set; }
        public int perPage { get; set; }
    }
}
