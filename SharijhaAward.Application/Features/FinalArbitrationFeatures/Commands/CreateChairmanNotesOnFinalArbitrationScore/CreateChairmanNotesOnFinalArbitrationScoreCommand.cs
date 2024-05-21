using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Commands.CreateChairmanNotesOnFinalArbitrationScore
{
    public class CreateChairmanNotesOnFinalArbitrationScoreCommand : IRequest<BaseResponse<object>>
    {
        public int FinalArbitrationScoreId { get; set; }
        public string Note { get; set; } = null!;
        public string? lang { get; set; }
    }
}
