using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InstructionsFeatures.Queries.GetInstructionBySlugId
{
    public class GetInstructionBySlugIdQuery : IRequest<BaseResponse<GetInstructionBySlugIdDto>>
    {
        public int? Id { get; set; }
        public string? Slug { get; set; }
        public string? lang { get; set; }
    }
}
