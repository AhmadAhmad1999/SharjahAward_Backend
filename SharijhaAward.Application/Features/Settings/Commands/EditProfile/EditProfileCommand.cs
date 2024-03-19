using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Commands.EditProfile
{
    public class EditProfileCommand : IRequest<BaseResponse<object>>
    {
        public string PhoneNumber { get; set; } = null!;
        public IFormFile? ProfileImage { get; set; }
        public string? WWWRootFilePath { get; set; }
        public string? Token { get; set; }
        public string? lang { get; set; }
    }
}
