using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributesBySectionId
{
    public class GetAllDynamicAttributesBySectionIdQuery : IRequest<BaseResponse<List<DynamicAttributeListVM>>>
    {
        public int SectionId { get; set; }
        public string lang { get; set; } = string.Empty;
        public int page { get; set; }
        public int perPage { get; set; }
    }
}
