using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DigitalSignatureFeatures.Queries.GetDigitalSignatureById
{
    public class GetDigitalSignatureByIdQuery : IRequest<BaseResponse<GetDigitalSignatureByIdDto>>
    {
        public int Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
