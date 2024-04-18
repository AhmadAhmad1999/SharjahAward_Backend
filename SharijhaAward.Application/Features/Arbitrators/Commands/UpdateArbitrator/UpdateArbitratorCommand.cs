using MediatR;
using SharijhaAward.Application.Helpers.AddDynamicAttributeValue;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.UpdateArbitrator
{
    public class UpdateArbitratorCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool isChairman { get; set; } = false;
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
        public List<int> Categories { get; set; } = new List<int>();
        public List<int> ArbitratorClasses { get; set; } = new List<int>();
    }
}
