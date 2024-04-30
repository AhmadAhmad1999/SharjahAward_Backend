using MediatR;
using SharijhaAward.Application.Features.ArbitrationScalesFeatures.Commands.CreateArbitrationScale;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Commands.UpdateArbitrationScale
{
    public class UpdateArbitrationScaleCommand : IRequest<BaseResponse<object>>
    {
        public List<UpdateArbitrationScaleDto> ArbitrationScaleDtos { get; set; } = new List<UpdateArbitrationScaleDto>();
        public string? lang { get; set; }
    }
}
