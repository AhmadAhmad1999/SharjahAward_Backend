using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Commands.UpdateAssignedFormsToArbitrator
{
    public class UpdateAssignedFormsToArbitratorCommand : IRequest<BaseResponse<object>>
    {
        public int ArbitratorId { get; set; }
        public List<int> NewFormsIds { get; set; } = new List<int>();
        public List<int> DeleteFormsIds { get; set; } = new List<int>();
        public string? lang { get; set; }
        public string? Token { get; set; }
    }
}
