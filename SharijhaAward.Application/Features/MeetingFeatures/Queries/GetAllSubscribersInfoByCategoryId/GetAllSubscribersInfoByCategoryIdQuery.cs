using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.MeetingFeatures.Queries.GetAllSubscribersInfoByCategoryId
{
    public class GetAllSubscribersInfoByCategoryIdQuery : IRequest<BaseResponse<List<GetAllSubscribersInfoByCategoryIdListVM>>>
    {
        public int Id { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public string? lang { get; set; }
    }
}
