using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Commands.RejectRelatingRequest
{
    public class RejectRelatingRequestCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
