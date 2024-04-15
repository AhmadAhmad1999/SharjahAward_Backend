using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.RoleFeatures.Commands.CreateRole
{
    public class CreateRoleCommand : IRequest<BaseResponse<object>>
    {
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public List<int> PermissionsIds { get; set; } = new List<int>();
        public string? lang { get; set; }
    }
}
