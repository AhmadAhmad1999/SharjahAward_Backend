using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd
{
    public class GetAllDynamicAttributeSectionsForAddQuery : IRequest<BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>>
    {
        public int? ProvidedFormId { get; set; }
        public Guid? ArbitratorId { get; set; }
        public Guid? CoordinatorId { get; set; }
        public Guid? CycleId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
