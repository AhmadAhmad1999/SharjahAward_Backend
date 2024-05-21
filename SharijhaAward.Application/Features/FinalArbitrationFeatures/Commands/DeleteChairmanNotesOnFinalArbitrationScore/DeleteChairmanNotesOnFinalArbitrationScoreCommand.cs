using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Commands.DeleteChairmanNotesOnFinalArbitrationScore
{
    public class DeleteChairmanNotesOnFinalArbitrationScoreCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
