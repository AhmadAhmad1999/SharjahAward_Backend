using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.InstructionsFeatures.Queries.GetAllInstructions
{
    public class GetAllInstructionsQuery : IRequest<BaseResponse<List<GetAllInstructionsListVM>>>
    {
        public List<Filter>? filters { get; set; }
        public string? lang { get; set; }
        public int page { get; set; }
        public int perPage { get; set; }
    }
}
