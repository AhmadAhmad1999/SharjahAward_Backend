using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;

namespace SharijhaAward.Application.Features.Coordinators.Queries.SearchForCoordinator
{
    public class CoordinatorSearchListVM
    {
        public int Id {  get; set; }
        public string Name { get; set; } = string.Empty;
        [EmailValidation]
        public string Email { get; set; } = string.Empty;
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; } = string.Empty;
        public string SchoolName { get; set; } = string.Empty;
        public string PersonalPhoto { get; set; } = string.Empty;
    }
}
