using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Commands.UpdateChairmanNotesOnInitialArbitration
{
    public class UpdateChairmanNotesOnInitialArbitrationCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string Note { get; set; } = null!;
        public string? lang { get; set; }
    }
}
