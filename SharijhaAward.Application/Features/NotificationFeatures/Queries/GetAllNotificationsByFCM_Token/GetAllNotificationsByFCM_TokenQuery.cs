using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.NotificationFeatures.Queries.GetAllNotificationsByFCM_Token
{
    public class GetAllNotificationsByFCM_TokenQuery : IRequest<BaseResponse<List<GetAllNotificationsByFCM_TokenListVM>>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }
        public string? DeviceToken { get; set; }
        public string? lang { get; set; }
    }
}
