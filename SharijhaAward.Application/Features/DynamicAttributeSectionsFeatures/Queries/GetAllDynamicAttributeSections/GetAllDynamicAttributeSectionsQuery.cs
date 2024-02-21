using MediatR;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSections
{
    public class GetAllDynamicAttributeSectionsQuery : IRequest<List<DynamicAttributeSectionListVM>>
    {
        public string lang { get; set; } = string.Empty;
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
