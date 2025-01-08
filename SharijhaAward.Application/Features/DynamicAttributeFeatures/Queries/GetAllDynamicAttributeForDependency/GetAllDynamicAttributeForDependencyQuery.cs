using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributeForDependency
{
    public class GetAllDynamicAttributeForDependencyQuery : IRequest<BaseResponse<List<GetAllDynamicAttributeForDependencyListVM>>>
    {
        public int? CategoryId { get; set; }
        public int? AttributeTableNameId { get; set; }
        public int? EventId { get; set; }
        public InviteeTypes? InviteeType { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
