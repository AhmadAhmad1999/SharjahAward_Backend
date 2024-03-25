using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.Authentication.Login
{
    public class UserDataResponse
    {
        public Guid Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public Guid? RoleId { get; set; }
        public string? ImageURL { get; set; }
    }
}
