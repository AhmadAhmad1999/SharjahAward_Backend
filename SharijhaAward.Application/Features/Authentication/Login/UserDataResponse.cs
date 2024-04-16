using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.Authentication.Login
{
    public class UserDataResponse
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string? SubscriberId { get; set; }
        public string EnglishName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public int? RoleId { get; set; }
        public string? ImageURL { get; set; }
    }
}
