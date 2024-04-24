using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.UserFeatures.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<BaseResponse<object>>
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public List<int> RolesIds { get; set; } = new List<int>();
        public string? lang { get; set; }
    }
}
