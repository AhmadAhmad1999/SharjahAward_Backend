using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Commands.DeleteProfile
{
    public class DeleteProfileCommand : IRequest<BaseResponse<object>>
    {
        public string Email { get; set; } = null!;
        public string? Token { get; set; }
        public string? lang { get; set; }
    }
}
