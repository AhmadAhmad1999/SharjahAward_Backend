using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.NotificationFeatures.Queries.GetCountForNotifications
{
    public class GetCountForNotificationsQuery : IRequest<BaseResponse<GetCountForNotificationsDto>>
    {
        public string? DeviceToken { get; set; }
        public string? Token { get; set; }
        public string? lang { get; set; }
    }
}
