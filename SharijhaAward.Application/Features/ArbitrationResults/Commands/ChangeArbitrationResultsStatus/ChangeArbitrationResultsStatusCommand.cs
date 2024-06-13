using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationResults.Commands.ChangeArbitrationResultsStatus
{
    public class ChangeArbitrationResultsStatusCommand : IRequest<BaseResponse<object>>
    {
        public int FormId { get; set; }
        public bool isCerticate { get; set; }
        public string? lang { get; set; }
    }
}
