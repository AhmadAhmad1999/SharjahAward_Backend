using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.NotificationTemplateFeatures.Commands.UpdateNotificationTemplate
{
    public class UpdateNotificationTemplateCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
        public string ArabicBody { get; set; } = null!;
        public string EnglishBody { get; set; } = null!;
        public string? lang { get; set; }
    }
}
