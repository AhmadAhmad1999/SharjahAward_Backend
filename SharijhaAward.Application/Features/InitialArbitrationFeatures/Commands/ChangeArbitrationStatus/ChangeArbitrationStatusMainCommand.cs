using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Commands.ChangeArbitrationStatus
{
    public class ChangeArbitrationStatusMainCommand : IRequest<BaseResponse<object>>
    {
        public int ArbitrationId { get; set; }
        public FormStatus isAccepted { get; set; }
        public string? lang { get; set; }
        public List<ChairmanNotes> ChairmanNotes { get; set; } = new List<ChairmanNotes>();
    }
}
