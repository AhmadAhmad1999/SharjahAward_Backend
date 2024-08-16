using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetAllFormsForArbitrationAudit
{
    public class GetAllFormsForArbitrationAuditQuery : IRequest<BaseResponse<List<GetAllFormsForArbitrationAuditListVM>>>
    {
        public bool? ItExceededTheMarginOfDifferenceInArbitrationScores { get; set; }
        public ArbitrationType? ArbitrationType { get; set; }
        public string? Token { get; set; }
        public bool? AsChairman { get; set; }
        public string? lang { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
    }
}
