using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById
{
    public class CoordinatorDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        [EmailValidation]
        public string Email { get; set; } = string.Empty;
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; } = string.Empty;
        public EducationType EducationType { get; set; }
        public Emirates Emirates { get; set; }
        public string PersonalPhoto { get; set; } = string.Empty;
        public List<EduEntityCoordinatorDto>? EntityCoordinator { get; set; }
       
    }
}
