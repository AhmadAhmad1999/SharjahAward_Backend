using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.IdentityModels
{
    public class UserToken : AuditableEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public string Token { get; set; } = null!;
        public string AppLanguage { get; set; } = null!;
        public string? DeviceToken { get; set; }
        public PlatformType Platform { get; set; }
    }
}
