using MediatR;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.PasswordValidationAttributeHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.CreateArbitrator
{
    public class CreateArbitratorCommand : IRequest<BaseResponse<int>>
    {
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; } = string.Empty;
        [EmailValidation]
        public string Email { get; set; } = string.Empty;
        public bool isChairman { get; set; } = false;
        [PasswordValidation]
        public string Password { get; set; } = null!;
        public string? lang { get; set; }
        public List<int> Categories { get; set; } = new List<int>();
        public List<int> ArbitratorCateogryClasses { get; set; } = new List<int>();
        public string? WWWRootFilePath { get; set; }
    }
}
