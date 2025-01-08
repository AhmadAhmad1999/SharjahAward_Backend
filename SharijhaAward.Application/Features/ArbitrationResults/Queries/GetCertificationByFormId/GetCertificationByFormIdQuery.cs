using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationResults.Queries.GetCertificationByFormId
{
    public class GetCertificationByFormIdQuery : IRequest<BaseResponse<GetCertificationByFormIdDto>>
    {
        public int FormId { get; set; }
        public string? lang { get; set; }
    }
}
