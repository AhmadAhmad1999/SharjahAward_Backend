using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ExplanatoryMessageFeatures.Queries.GetAllExplanatoryMessage
{
    public class GetAllExplanatoryMessageQuery : IRequest<BaseResponse<List<GetAllExplanatoryMessageListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; }
        public int perPage { get; set; }
    }
}
