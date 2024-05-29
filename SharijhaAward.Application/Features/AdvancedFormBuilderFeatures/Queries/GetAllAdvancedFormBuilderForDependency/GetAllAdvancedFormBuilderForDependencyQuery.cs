using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllAdvancedFormBuilderForDependency
{
    public class GetAllAdvancedFormBuilderForDependencyQuery : IRequest<BaseResponse<List<GetAllAdvancedFormBuilderForDependencyListVM>>>
    {
        public int VirtualTableForSectionId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
