using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd
{
    public class GetAllDynamicAttributeSectionsForAddQuery : IRequest<BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>>
    {
        public int? ProvidedFormId { get; set; }
        public int? ArbitratorId { get; set; }
        public int? CoordinatorId { get; set; }
        public int? CycleId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
