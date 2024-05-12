using MediatR;
using SharijhaAward.Application.Features.User.Queries.ChangePassword;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.Settings.Commands.ResetPassword
{
    public class ResetPasswordCommand : IRequest<BaseResponse<object>>
    {
        public string NewPassword { get; set; } = string.Empty;
        public string? Token { get; set; } = string.Empty;
        public string lang { get; set; } = string.Empty;
    }
}
