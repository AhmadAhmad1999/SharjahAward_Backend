using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.AddFinalScoreToArbitratoinForFormId
{
    public class AddFinalScoreToArbitratoinForFormIdCommand : IRequest<BaseResponse<object>>
    {
        public int FormId { get; set; }
        public float FinalScore { get; set; }
        public string? Token { get; set; }
        public string? lang { get; set; }
    }
}
