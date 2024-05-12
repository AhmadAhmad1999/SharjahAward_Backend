using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.Authentication.Login
{
    public class LoginCommand : IRequest<AuthenticationResponse>
    {
        public bool intoAdminDashboard { get; set; } = false;
        public string Email { get; set; }=string.Empty;
        public string Password { get; set; } = string.Empty;
        public string? lang { get; set; }
        public string? DeviceToken { get; set; }
        public PlatformType? Platform { get; set; }
    }
}
