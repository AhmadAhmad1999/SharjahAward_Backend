using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.StaticNotificationFeatures.Queries.GetAllStaticNotifications
{
    public class GetAllStaticNotificationsQuery : IRequest<BaseResponse<List<GetAllStaticNotificationsListVM>>>
    {
        public string? lang { get; set; }
        public List<Filter>? filters { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
    }
}
