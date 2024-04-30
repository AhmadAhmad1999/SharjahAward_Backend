using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Commands.CreateArbitrationScale
{
    public class CreateArbitrationScaleCommand : IRequest<BaseResponse<object>>
    {
        public List<ArbitrationScaleDto> ArbitrationScaleDtos { get; set; } = new List<ArbitrationScaleDto>();
        public int CategoryId { get; set; }
        public string? lang { get; set; }
    }
}
