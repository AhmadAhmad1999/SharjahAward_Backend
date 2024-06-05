using MediatR;
using SharijhaAward.Application.Features.Classes.Queries.GetAllClasses;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.NotificationTemplateFeatures.Queries.GetAllNotificationTemplates
{
    public class GetAllNotificationTemplatesQuery : IRequest<BaseResponse<List<GetAllNotificationTemplatesListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; }
        public int perPage { get; set; }
    }
}
