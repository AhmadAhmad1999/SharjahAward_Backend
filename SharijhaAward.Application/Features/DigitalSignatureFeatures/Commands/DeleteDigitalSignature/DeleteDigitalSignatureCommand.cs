using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DigitalSignatureFeatures.Commands.DeleteDigitalSignature
{
    public class DeleteDigitalSignatureCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
