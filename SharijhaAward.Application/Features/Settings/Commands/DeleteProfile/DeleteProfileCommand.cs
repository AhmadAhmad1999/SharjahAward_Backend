using MediatR;
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.Settings.Commands.DeleteProfile
{
    public class DeleteProfileCommand : IRequest<BaseResponse<object>>
    {
        [EmailValidation]
        public string Email { get; set; } = null!;
        public string? Token { get; set; }
        public string? lang { get; set; }
    }
}
