using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Authentication.CheckConfirmationCodeForForgettonPassword
{
    public class CheckConfirmationCodeForForgettonPasswordCommand : IRequest<BaseResponse<object>>
    {
        public Guid Id { get; set; }
        public int ConfirmationCode { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
