using MediatR;
using SharijhaAward.Application.Helpers.AddDynamicAttributeValue;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.CreateArbitrator
{
    public class CreateArbitratorCommand : IRequest<BaseResponse<Guid>>
    {
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? lang { get; set; }
        public List<Guid> Categories { get; set; } = new List<Guid>();
        public List<AddDynamicAttributeValueMainCommand> DynamicAttributesWithValues { get; set; } = new List<AddDynamicAttributeValueMainCommand>();
        public string? WWWRootFilePath { get; set; }
    }
}
