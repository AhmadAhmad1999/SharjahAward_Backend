using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute
{
    public class CreateDynamicAttributeResponse : BaseResponse<object>
    {
        public CreateDynamicAttributeResponse() : base() { }
        public CreateDynamicAttributeDto CreateDynamicAttributeDto { get; set; }
    }
}
