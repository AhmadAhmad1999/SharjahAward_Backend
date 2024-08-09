using MediatR;
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.PasswordValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.Authentication.Login
{
    public class LoginCommand : IRequest<AuthenticationResponse>
    {
        public bool intoAdminDashboard { get; set; } = false;
        [EmailValidation]
        public string Email { get; set; }=string.Empty;
        [PasswordValidation]
        public string Password { get; set; } = string.Empty;
        public string? lang { get; set; }
        public string? DeviceToken { get; set; }
        public PlatformType? Platform { get; set; }
    }
}
