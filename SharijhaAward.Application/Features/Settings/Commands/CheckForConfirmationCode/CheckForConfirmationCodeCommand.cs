using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Commands.CheckForConfirmationCode
{
    public class CheckForConfirmationCodeCommand : IRequest<BaseResponse<object>>
    {
        public int ConfirmationCode { get; set; }
        public string Token { get; set; } = string.Empty;
        public string lang { get; set; } = string.Empty;
    }
}
