using MediatR;
using SharijhaAward.Application.Helpers.PasswordValidationAttributeHelper;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Commands.ResetPassword
{
    public class ResetPasswordCommand : IRequest<BaseResponse<object>>
    {
        [PasswordValidation]
        public string NewPassword { get; set; } = string.Empty;
        public string? Token { get; set; } = string.Empty;
        public string lang { get; set; } = string.Empty;
    }
}
