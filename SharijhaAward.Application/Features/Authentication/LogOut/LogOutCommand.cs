using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Authentication.LogOut
{
    public class LogOutCommand : IRequest<BaseResponse<object>>
    {
        public string? token { get; set; }
        public string? lang { get; set; }
    }
}
