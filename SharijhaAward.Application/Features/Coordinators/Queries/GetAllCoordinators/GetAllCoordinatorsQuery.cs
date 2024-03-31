using MediatR;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributesBySectionId;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Coordinators.Queries.GetAllCoordinators
{
    public class GetAllCoordinatorsQuery : IRequest<BaseResponse<List<GetAllCoordinatorsListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
