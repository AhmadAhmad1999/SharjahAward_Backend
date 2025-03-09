using MediatR;
using SharijhaAward.Application.Features.Circulars.Command.CreateCircular;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Circulars.Command.UpdateCircular
{
    public class UpdateCircularCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string CircularText { get; set; } = string.Empty;
        public List<int>? CoordinatorId { get; set; }
        public List<int>? ArbitratorId { get; set; }
        public List<int>? ChairmanId { get; set; }
        public List<int>? SubcommitteeOfficerId { get; set; }
        public List<int>? ChairmanOfCommitteesId { get; set; }
        public List<int>? ExpertId { get; set; }
        public List<int>? QualityId { get; set; }
        public bool AllCoordinators { get; set; }
        public bool AllArbitrators { get; set; }
        public bool AllChairmans { get; set; }
        public bool AllSubcommitteeOfficers { get; set; }
        public bool AllChairmanOfCommittees { get; set; }
        public bool AllExperts { get; set; }
        public bool AllQualities { get; set; }
        public string? lang { get; set; }
        public string? token { get; set; }
        public List<int> CircularAttachmentsToDelete { get; set; } = new List<int>();
        public List<UpdateCircularFilesDto> CircularAttachmentsToUpdate { get; set; } = new List<UpdateCircularFilesDto>();
        public List<CircularFilesDto> CircularAttachmentsToAdd { get; set; } = new List<CircularFilesDto>();
    }
}
