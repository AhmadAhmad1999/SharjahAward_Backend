using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.NotificationFeatures.Queries.GetAllNotificationsByFCM_Token_Mobile
{
    public class GetAllNotificationsByFCM_Token_MobileQuery : IRequest<BaseResponse<List<GetAllNotificationsByFCM_Token_MobileListVM>>>
    {
        public int page { get; set; }
        public int perPage { get; set; }
        public string? DeviceToken { get; set; }
        public string? Token { get; set; }
        public string? lang { get; set; }
    }
}
