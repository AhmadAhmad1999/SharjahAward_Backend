using MediatR;
using SharijhaAward.Application.Helpers.AddDynamicAttributeValue;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.UpdateArbitrator
{
    public class UpdateArbitratorCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; } = string.Empty;
        [EmailValidation]
        public string Email { get; set; } = string.Empty;
        public bool isChairman { get; set; } = false;
        public ArbitrationLanguage ArbitrationLanguage { get; set; }
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
        public List<int> Categories { get; set; } = new List<int>();
        public List<int> ArbitratorCategoryClasses { get; set; } = new List<int>();
    }
}
