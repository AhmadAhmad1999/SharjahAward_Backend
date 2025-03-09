using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetFinalArbitrationById
{
    public class GetFinalArbitrationByIdQuery : IRequest<BaseResponse<GetFinalArbitrationByIdMainDto>>
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
