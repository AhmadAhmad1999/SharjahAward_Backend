using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InstructionsFeatures.Queries.GetAllInstructions
{
    public class GetAllInstructionsQuery : IRequest<BaseResponse<List<GetAllInstructionsListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
