using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Commands.CreateFinalArbitration
{
    public class CreateFinalArbitrationCommand : IRequest<BaseResponse<object>>
    {
        public float FinalScore { get; set; }
        public int FormId { get; set; }
        public string? Token { get; set; }
        public string? lang { get; set; }
    }
}
