using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Helpers.PasswordValidationAttributeHelper;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DigitalSignatureFeatures.Commands.UpdateDigitalSignature
{
    public class UpdateDigitalSignatureCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public IFormFile? Image { get; set; }
        public bool UpdateOnImage { get; set; }
        public string UserName { get; set; } = null!;
        [PasswordValidation]
        public string Password { get; set; } = null!;
        public string OldUserName { get; set; } = null!;
        public string OldPassword { get; set; } = null!;
        public string ArabicFullName { get; set; } = null!;
        public string EnglishFullName { get; set; } = null!;
        public string EnglishOccupation { get; set; } = null!;
        public string ArabicOccupation { get; set; } = null!;
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
    }
}
