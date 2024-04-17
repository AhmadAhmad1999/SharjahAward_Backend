using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForView
{
    public class GetAllDynamicAttributeSectionsForViewQuery : IRequest<BaseResponse<List<DynamicAttributeSectionListVM>>>
    {
        public int? CategoryId { get; set; }
        public bool? isArbitrator { get; set; }
        public string lang { get; set; } = string.Empty;
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
