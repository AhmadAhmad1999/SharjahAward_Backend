using MediatR;
using SharijhaAward.Application.Responses;
namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllAttributeOperations
{
    public class GetAllAttributeOperationsQuery : IRequest<BaseResponse<List<GetAllAttributeOperationsListVM>>>
    {
        public string lang { get; set; } = string.Empty;
    }
}
