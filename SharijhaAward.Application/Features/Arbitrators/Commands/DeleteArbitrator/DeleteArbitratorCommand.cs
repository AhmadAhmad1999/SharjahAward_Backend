using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.DeleteArbitrator
{
    public class DeleteArbitratorCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
