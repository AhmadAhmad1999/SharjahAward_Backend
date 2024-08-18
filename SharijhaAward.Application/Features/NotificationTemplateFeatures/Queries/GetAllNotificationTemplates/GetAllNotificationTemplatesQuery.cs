using MediatR;
using SharijhaAward.Application.Features.Classes.Queries.GetAllClasses;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.NotificationTemplateFeatures.Queries.GetAllNotificationTemplates
{
    public class GetAllNotificationTemplatesQuery : IRequest<BaseResponse<List<GetAllNotificationTemplatesListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public List<Filter>? filters { get; set; }
    }
}
