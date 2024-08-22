using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Commands.CreateFinalArbitrationScore
{
    public class CreateFinalArbitrationScoreCommand : IRequest<BaseResponse<object>>
    {
        public List<CreateFinalArbitrationScoreMainCommand> CreateFinalArbitrationScoreMainCommand { get; set; } = new List<CreateFinalArbitrationScoreMainCommand>();
        public string? lang { get; set; }
        public bool isDoneArbitration { get; set; }
        public int FinalArbitrationId { get; set; }
        public string? Token { get; set; }
    }
}
