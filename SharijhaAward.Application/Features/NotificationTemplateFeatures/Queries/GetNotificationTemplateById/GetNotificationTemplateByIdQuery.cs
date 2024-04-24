using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.NotificationTemplateFeatures.Queries.GetNotificationTemplateById
{
    public class GetNotificationTemplateByIdQuery : IRequest<BaseResponse<GetNotificationTemplateByIdDto>>
    {
        public int Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
