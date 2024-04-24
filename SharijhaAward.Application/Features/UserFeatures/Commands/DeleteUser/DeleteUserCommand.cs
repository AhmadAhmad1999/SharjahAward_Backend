using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.UserFeatures.Commands.DeleteUser
{
    public class DeleteUserCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
