using MediatR;
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.PasswordValidationAttributeHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.Authentication.SignUp
{
    public class SignUpCommand : IRequest<AuthenticationResponse>
    {
        [EmailValidation]
        public string Email { get; set; } = string.Empty;
        [PasswordValidation]
        public string Password { get; set; } = string.Empty;
        public string RoleName { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; } = null!;
        public string? lang { get; set; }
    }
}
