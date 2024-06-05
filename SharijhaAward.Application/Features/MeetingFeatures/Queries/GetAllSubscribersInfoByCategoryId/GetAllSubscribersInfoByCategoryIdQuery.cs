using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.MeetingFeatures.Queries.GetAllSubscribersInfoByCategoryId
{
    public class GetAllSubscribersInfoByCategoryIdQuery : IRequest<BaseResponse<List<GetAllSubscribersInfoByCategoryIdListVM>>>
    {
        public List<int> Ids { get; set; } = new List<int>();
        public int page { get; set; }
        public int perPage { get; set; }
        public string? lang { get; set; }
    }
}
