using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Commands.SendConfirmationCodeForResetPassword
{
    public class SendConfirmationCodeForResetPasswordCommand : IRequest<BaseResponse<object>>
    {
        public string? token { get; set; }
        public string? lang { get; set; }
    }
}
