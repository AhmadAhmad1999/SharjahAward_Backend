using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Commands.SwitchArbitrationFeature
{
    public class SwitchArbitrationCommand : IRequest<BaseResponse<object>>
    {
        public int OldArbitratorId { get; set; }
        public int NewArbitratorId { get; set; }
        public int ProvidedFormId { get; set; }
        public string? lang { get; set; }
    }
}
