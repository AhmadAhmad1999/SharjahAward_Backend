using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.Authentication.SingUpFromAdminDashboard
{
    public class SingUpFromAdminDashboardCommand : IRequest<AuthenticationResponse>
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string RoleName { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public string? lang { get; set; }
    }
}
