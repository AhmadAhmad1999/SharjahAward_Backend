using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.Authentication.CheckConfirmationCodeForSignUp
{
    public class CheckConfirmationCodeForSignUpCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public int ConfirmationCode { get; set; }
        public PlatformType? PlatformType { get; set; }
        public string? lang { get; set; }
        public string? DeviceToken { get; set; }
    }
}
