using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.PermissionFeatures.Queries.GetAllPermissions
{
    public class GetAllPermissionsQuery : IRequest<BaseResponse<List<GetAllPermissionsListVM>>>
    {
        public string? lang { get; set; }
    }
}
