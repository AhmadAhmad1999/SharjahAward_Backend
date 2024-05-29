using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetAllFormsForArbitrationAudit
{
    public class GetAllFormsForArbitrationAuditQuery : IRequest<BaseResponse<List<GetAllFormsForArbitrationAuditListVM>>>
    {
        public bool? ItExceededTheMarginOfDifferenceInArbitrationScores { get; set; }
        public string? Token { get; set; }
        public string? lang { get; set; }
        public int page { get; set; } = 1;
        public int pageSize { get; set; } = 10;
    }
}
