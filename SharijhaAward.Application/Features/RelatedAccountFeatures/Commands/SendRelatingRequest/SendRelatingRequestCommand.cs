using MediatR;
using SharijhaAward.Application.Responses;
namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Commands.SendRelatingRequest
{
    public class SendRelatingRequestCommand : IRequest<BaseResponse<object>>
    {
        public string ReceiverEmail { get; set; } = null!;
        public string lang { get; set; } = string.Empty;
        public string? token { get; set; }
    }
}
