using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.StaticNotificationFeatures.Queries.GetStaticNotificationById
{
    public class GetStaticNotificationByIdQuery : IRequest<BaseResponse<GetStaticNotificationByIdDto>>
    {
        public int Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
