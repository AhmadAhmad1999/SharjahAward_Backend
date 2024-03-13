using MediatR;
using SharijhaAward.Application.Responses;
namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Commands.SendRelatingRequest
{
    public class SendRelatingRequestCommand : IRequest<BaseResponse<object>>
    {
        public Guid ReceiverId { get; set; }
        public string lang { get; set; } = string.Empty;
        public string? token { get; set; }
    }
}
