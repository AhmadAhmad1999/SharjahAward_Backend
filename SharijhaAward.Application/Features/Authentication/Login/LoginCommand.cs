using MediatR;
using SharijhaAward.Application.Helpers.PasswordValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.Authentication.Login
{
    public class LoginCommand : IRequest<AuthenticationResponse>
    {
        public bool intoAdminDashboard { get; set; } = false;
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }=string.Empty;
        [PasswordValidation(ErrorMessage = "Password must contain at least 1 uppercase letter, 1 lowercase letter, 1 special character, 1 number, and be at least 8 characters long.")]
        public string Password { get; set; } = string.Empty;
        public string? lang { get; set; }
        public string? DeviceToken { get; set; }
        public PlatformType? Platform { get; set; }
    }
}
