using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Authentication.ForgetPassword
{
    public class ForgetPasswordCommand : IRequest<BaseResponse<Guid>>
    {
        public string Email { get; set; } = null!;
        public string? lang { get; set; }
    }
}
