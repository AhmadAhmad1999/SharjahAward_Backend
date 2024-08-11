using MediatR;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.RoleFeatures.Commands.CreateRole
{
    public class CreateRoleCommand : IRequest<BaseResponse<object>>
    {
        [ArabicNameValidation]
        public string ArabicName { get; set; } = null!;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = null!;
        public bool HaveFullAccess { get; set; }
        public List<int> PermissionsIds { get; set; } = new List<int>();
        public string? lang { get; set; }
    }
}
