using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForView
{
    public class GetAllDynamicAttributeSectionsForViewQuery : IRequest<BaseResponse<List<DynamicAttributeSectionListVM>>>
    {
        public int? CategoryId { get; set; }
        public bool? isArbitrator { get; set; }
        public int? EventId { get; set; }
        public InviteeTypes? InviteeType { get; set; }
        public string lang { get; set; } = string.Empty;
        public string WWWRootFilePath { get; set; } = string.Empty;
        public int page { get; set; }
        public int perPage { get; set; }
    }
}
