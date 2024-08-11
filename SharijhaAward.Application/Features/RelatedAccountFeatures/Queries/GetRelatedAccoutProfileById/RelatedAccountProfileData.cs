
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using SharijhaAward.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetRelatedAccoutProfileById
{
    public class RelatedAccountProfileData
    {
        public int Id { get; set; }
        public string? SubscriberId { get; set; }
        [EmailValidation]
        public string Email { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? ImageURL { get; set; }
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; } = null!;
        public Gender Gender { get; set; }
    }
}
