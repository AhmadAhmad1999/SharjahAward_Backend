using MediatR;
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.Authentication.ForgetPassword
{
    public class ForgetPasswordCommand : IRequest<BaseResponse<int>>
    {
        [EmailValidation]
        public string Email { get; set; } = null!;
        public string? lang { get; set; }
    }
}
