using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Helpers.AddDynamicAttributeValue;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using SharijhaAward.Application.Helpers.UpdateDynamicAttributeValue;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.Coordinators.Commands.UpdateCoordinator
{
    public class UpdateCoordinatorCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        // [ArabicNameValidation(ErrorMessage = "Arabic name must only contain Arabic characters.")]
        public string arabicName { get; set; } = string.Empty;
        // [EnglishNameValidation(ErrorMessage = "English name must only contain English characters.")]
        public string englishName { get; set; } = string.Empty;
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string email { get; set; } = string.Empty;
        [PhoneNumberValidation]
        public string phoneNumber { get; set; } = string.Empty;
        public EducationType educationType { get; set; }
        public Emirates emirates { get; set; }
        public bool updateOnPersonalPhoto {  get; set; }
        public IFormFile? personalPhoto { get; set; } = null!;
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
        public List<int>? EducationalEntitiesIds { get; set; }
      
    }
}
