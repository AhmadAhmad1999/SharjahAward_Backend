using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.NotificationFeatures.Queries.GetAllNotifications
{
    public class GetAllNotificationsQuery : IRequest<BaseResponse<List<GetAllNotificationsListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public List<Filter>? filters { get; set; }
    }
}
