using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.NotificationTemplateFeatures.Commands.DeleteNotificationTemplate
{
    public class DeleteNotificationTemplateCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
