using SharijhaAward.Application.Features.Authentication.Login;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Responses
{
    public class AuthenticationResponse
    {
        public string token { get; set; } = string.Empty;
        public UserDataResponse user { get; set; } = null!;
        public List<Permission>? permissions { get; set; } = null!;
        public string message { get; set; } = string.Empty;
        public bool isSucceed { get; set; } = false;
        public int? ActiveCycleId { get; set; }
        public string? CycleName { get; set; }
        public int? CycleNumber { get; set; } 
        public List<UserPermissionsDto>? UserPermissions { get; set; }
        public bool NeedVerification { get; set; }
    }
}
