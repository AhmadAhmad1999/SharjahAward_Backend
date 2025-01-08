using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd
{
    public class GetAllDynamicAttributeSectionsForAddQuery : IRequest<BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>>
    {
        public int? ProvidedFormId { get; set; }
        public int? ArbitratorId { get; set; }
        public int? CoordinatorId { get; set; }
        public bool? isArbitrator { get; set; }
        public int? EventId { get; set; }
        public InviteeTypes? InviteeType { get; set; }
        public int? PersonalInviteeId { get; set; }
        public int? GroupInviteeId { get; set; }
        public int? PersonalInviteeNumber { get; set; }
        public int? GroupInviteeNumber { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
