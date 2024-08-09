using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using SharijhaAward.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.Settings.Queries.GetProfileById
{
    public class GetProfileByIdDto
    {
        public int Id { get; set; }
        public string? SubscriberId { get; set; }
        [EmailValidation]
        public string Email { get; set; } = null!;
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; } = null!;
        public Gender Gender { get; set; }
        public string? ImageURL { get; set; }
    }
}
