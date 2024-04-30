using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Commands.DeleteArbitrationScale
{
    public class DeleteArbitrationScaleCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
