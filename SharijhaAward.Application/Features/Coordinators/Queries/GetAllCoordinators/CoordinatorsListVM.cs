using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;

namespace SharijhaAward.Application.Features.Coordinators.Queries.GetAllCoordinators
{
    public class CoordinatorsListVM
    {
        public int Id { get; set; }
        [ArabicNameValidation]
        public string ArabicName { get; set; } = null!;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = null!;
        [EmailValidation]
        public string Email { get; set; } = null!;
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; } = null!;
       
    }
}
