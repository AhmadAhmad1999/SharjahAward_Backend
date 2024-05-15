using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Commands.CreateChairmanNotesOnInitialArbitration
{
    public class CreateChairmanNotesOnInitialArbitrationCommand : IRequest<BaseResponse<object>>
    {
        public int InitialArbitrationId { get; set; }
        public string Note { get; set; } = null!;
        public string? lang { get; set; }
    }
}
