using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;

namespace SharijhaAward.Application.Features.RoleFeatures.Queries.GetRoleById
{
    public class GetRoleByIdDto
    {
        public int Id { get; set; }
        [ArabicNameValidation]
        public string ArabicName { get; set; } = null!;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = null!;
        public List<int> PermissionsIds { get; set; } = new List<int>();
        public bool HaveFullAccess { get; set; }
    }
}
