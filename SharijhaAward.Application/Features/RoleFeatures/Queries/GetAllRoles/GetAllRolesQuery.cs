using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.RoleFeatures.Queries.GetAllRoles
{
    public class GetAllRolesQuery : IRequest<BaseResponse<List<GetAllRolesListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; }
        public int perPage { get; set; }
    }
}
