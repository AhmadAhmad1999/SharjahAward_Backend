using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForView
{
    public class GetAllDynamicAttributeSectionsForViewQuery : IRequest<BaseResponse<List<DynamicAttributeSectionListVM>>>
    {
        public int? CategoryId { get; set; }
        public int? CycleId { get; set; }
        public bool isArbitrator { get; set; } = false;
        public string lang { get; set; } = string.Empty;
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
