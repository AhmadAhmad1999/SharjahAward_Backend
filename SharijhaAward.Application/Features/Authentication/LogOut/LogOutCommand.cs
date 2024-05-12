using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.Authentication.LogOut
{
    public class LogOutCommand : IRequest<BaseResponse<object>>
    {
        public string? token { get; set; }
        public PlatformType Platform { get; set; }
        public string? lang { get; set; }
    }
}
