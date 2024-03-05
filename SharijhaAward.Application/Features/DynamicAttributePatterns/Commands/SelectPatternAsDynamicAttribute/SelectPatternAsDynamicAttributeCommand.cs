using MediatR;
using SharijhaAward.Application.Responses;
namespace SharijhaAward.Application.Features.DynamicAttributePatterns.Commands.SelectPatternAsDynamicAttribute
{
    public class SelectPatternAsDynamicAttributeCommand : IRequest<BaseResponse<SelectPatternAsDynamicAttributeResponse>>
    {
        public int DynamicAttributePatternId { get; set; }
        public int DynamicAttributeSectionId { get; set; }
        public string? lang { get; set; }
    }
}
