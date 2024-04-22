using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Commands.ChangeStatusForAssignedForm
{
    public class ChangeStatusForAssignedFormCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public bool isAccepted { get; set; }
        public string? lang { get; set; }
    }
}
