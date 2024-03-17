using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Commands.SendConfirmationCodeForChangePassword
{
    public class SendConfirmationCodeForChangePasswordCommand : IRequest<BaseResponse<object>>
    {
        public string? token { get; set; }
        public string? lang { get; set; }
    }
}
