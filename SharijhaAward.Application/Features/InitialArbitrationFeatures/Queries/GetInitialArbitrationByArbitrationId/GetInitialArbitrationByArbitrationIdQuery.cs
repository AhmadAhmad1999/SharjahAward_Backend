using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId
{
    public class GetInitialArbitrationByArbitrationIdQuery : IRequest<BaseResponse<GetInitialArbitrationByArbitrationIdResponse>>
    {
        public int ArbitrationId { get; set; }
        public string? lang { get; set; }
        public string? Token { get; set; }
        public bool asNormalArbitrator { get; set; }
        public bool? asChairman { get; set; }
        public bool AsFullAccess { get; set; }
        public bool asSubcommitteeOfficer { get; set; }
        public bool asChairmanOfCommittees { get; set; }
        public bool asExpert { get; set; }
        public bool asQuality { get; set; }
    }
}
