using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Authentication.CheckConfirmationCodeForSignUp
{
    public class CheckConfirmationCodeForSignUpCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public int ConfirmationCode { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
