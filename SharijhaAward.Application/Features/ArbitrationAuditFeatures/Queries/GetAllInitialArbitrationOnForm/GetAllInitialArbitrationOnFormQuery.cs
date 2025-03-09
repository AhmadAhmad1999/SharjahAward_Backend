using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetAllInitialArbitrationOnForm
{
    public class GetAllInitialArbitrationOnFormQuery : IRequest<BaseResponse<List<GetAllInitialArbitrationOnFormListVM>>>
    {
        public int FormId { get; set; }
        public bool asNormalArbitrator { get; set; }
        public string? lang { get; set; }
    }
}
