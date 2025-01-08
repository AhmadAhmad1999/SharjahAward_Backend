using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.StaticNotificationFeatures.Commands.UpdateStaticNotificationStatus
{
    public class UpdateStaticNotificationStatusCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public bool isActive { get; set; }
        public string? lang { get; set; }
    }
}
