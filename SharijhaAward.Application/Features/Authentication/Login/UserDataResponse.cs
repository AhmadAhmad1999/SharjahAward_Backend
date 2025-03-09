using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using SharijhaAward.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.Authentication.Login
{
    public class UserDataResponse
    {
        public int Id { get; set; }
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        public string? SubscriberId { get; set; }
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        [EmailValidation]
        public string Email { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; } = null!;
        public List<int>? RoleId { get; set; }
        public List<string>? RoleName { get; set; }
        public string? ImageURL { get; set; }
        public bool AcceptOnResponsibilities { get; set; }
        public bool? isChairman { get; set; }
        public bool HasFullAccess { get; set; }
        public bool? isSubcommitteeOfficer { get; set; }
        public bool? isChairmanOfCommittees { get; set; }
        public bool? isExpert { get; set; }
        public bool? isQuality { get; set; }
    }
}
