using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Helpers.PasswordValidationAttributeHelper;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DigitalSignatureFeatures.Commands.CreateDigitalSignature
{
    public class CreateDigitalSignatureCommand : IRequest<BaseResponse<object>>
    {
        public IFormFile Image { get; set; } = null!;
        public string UserName { get; set; } = null!;
        [PasswordValidation]
        public string Password { get; set; } = null!;
        public string? Token { get; set; }
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
    }
}
