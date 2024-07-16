using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Commands.ChangeStatusForAssignedForm
{
    public class ChangeStatusForAssignedFormCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public FormStatus isAccepted { get; set; }
        public string? ReasonForRejecting { get; set; }
        public FormStatus isAcceptedFromChairman { get; set; }
        public string? token { get; set; }
        public string? lang { get; set; }
    }
}
