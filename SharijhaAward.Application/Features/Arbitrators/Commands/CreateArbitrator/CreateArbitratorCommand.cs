using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.PasswordValidationAttributeHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

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
        public ArbitrationLanguage ArbitrationLanguage { get; set; }
        public string? lang { get; set; }
        public List<ArbitratorCateogryClassesCommand> ArbitratorCateogryClasses { get; set; } = new List<ArbitratorCateogryClassesCommand>();
        public string? WWWRootFilePath { get; set; }
        public bool SendEmail { get; set; }
        public bool isSubcommitteeOfficer { get; set; } = false;
        public List<int> SubcommitteeOfficerCategories { get; set; } = new List<int>();
    }
}
