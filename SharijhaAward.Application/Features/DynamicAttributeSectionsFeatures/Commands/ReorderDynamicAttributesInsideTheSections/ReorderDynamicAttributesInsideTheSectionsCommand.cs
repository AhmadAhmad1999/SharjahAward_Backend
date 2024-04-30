using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.ReorderDynamicAttributesInsideTheSections
{
    public class ReorderDynamicAttributesInsideTheSectionsCommand : IRequest<BaseResponse<object>>
    {
        public List<DynamicAttributeSectionsDto> DynamicAttributeSectionsDto { get; set; } = new List<DynamicAttributeSectionsDto>();
        public string? lang { get; set; }
    }
}
