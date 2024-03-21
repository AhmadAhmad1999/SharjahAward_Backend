using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Authentication.SendConfirmationCodeForSignUp
{
    public class SendConfirmationCodeForSignUpCommand : IRequest<BaseResponse<object>>
    {
        public Guid Id { get; set; }
        public string? lang { get; set; }
    }
}
