using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetArbitrationAuditByArbitrationId
{
    public class GetArbitrationAuditByArbitrationIdQuery : IRequest<BaseResponse<GetArbitrationAuditByArbitrationIdResponse>>
    {
        public int FormId { get; set; }
        public bool asNormalArbitrator { get; set; }
        public bool? asChairman { get; set; }
        public bool AsFullAccess { get; set; }
        public bool asSubcommitteeOfficer { get; set; }
        public bool asChairmanOfCommittees { get; set; }
        public bool asExpert { get; set; }
        public bool asQuality { get; set; }
        public string? lang { get; set; }
        public string? Token { get; set; }
    }
}
