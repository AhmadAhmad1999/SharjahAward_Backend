using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Commands.UpdateAssignedFormsToArbitrator
{
    public class UpdateAssignedFormsToArbitratorCommand : IRequest<BaseResponse<object>>
    {
        public int ArbitratorId { get; set; }
        public List<int> FormsIds { get; set; } = new List<int>();
        public string? lang { get; set; }
    }
}
