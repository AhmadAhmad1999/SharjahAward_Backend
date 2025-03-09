using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAddForUser
{
    public class GetAllDynamicAttributeSectionsForAddForUserQuery : IRequest<BaseResponse<List<RolesListVM>>>
    {
        public int? UserId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
