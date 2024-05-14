using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Commands.CreateInitialArbitration
{
    public class CreateInitialArbitrationCommand : IRequest<BaseResponse<object>>
    {
        public List<InitialArbitrationMainCommand> InitialArbitrationMainCommand { get; set; } = new List<InitialArbitrationMainCommand>();
        public string? lang { get; set; }
        public bool isDoneArbitration { get; set; }
        public int ArbitrationId { get; set; }
    }
}
