using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.Authentication.UpdateFCMToken
{
    public class UpdateFCMTokenCommand : IRequest<BaseResponse<AuthenticationResponse>>
    {
        public string? token { get; set; }
        public string? lang { get; set; }
        public string? DeviceToken { get; set; }
        public PlatformType? Platform { get; set; }
    }
}
