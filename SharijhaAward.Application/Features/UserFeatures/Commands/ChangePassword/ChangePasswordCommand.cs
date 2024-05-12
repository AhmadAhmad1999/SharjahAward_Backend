using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.UserFeatures.Commands.ChangePassword
{
    public class ChangePasswordCommand : IRequest<BaseResponse<object>>
    {
        public int? Id { get; set; }
        public string NewPassword { get; set; } = null!;
        public string? lang { get; set; }
    }
}
