using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Commands.ChangeFinalArbitrationStatus
{
    public class ChangeFinalArbitrationStatusCommand : IRequest<BaseResponse<object>>
    {
        public int FinalArbitrationId { get; set; }
        public FormStatus isAccepted { get; set; }
        public string? Token { get; set; }
        public bool? AsChairman { get; set; }
        public string? ReasonForRejecting { get; set; }
        public string? lang { get; set; }
        public List<ChairmanNotesOnFinalArbitration> ChairmanNotes { get; set; } = new List<ChairmanNotesOnFinalArbitration>();
    }
}
