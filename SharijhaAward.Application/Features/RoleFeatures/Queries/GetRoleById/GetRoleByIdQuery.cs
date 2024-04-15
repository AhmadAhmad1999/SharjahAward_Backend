using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.RoleFeatures.Queries.GetRoleById
{
    public class GetRoleByIdQuery : IRequest<BaseResponse<GetRoleByIdDto>>
    {
        public int Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
