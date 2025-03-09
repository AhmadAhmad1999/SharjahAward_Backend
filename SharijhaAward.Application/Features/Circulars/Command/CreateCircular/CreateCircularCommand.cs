using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Circulars.Command.CreateCircular
{
    public class CreateCircularCommand : IRequest<BaseResponse<int>>
    {
        public string Title { get; set; } = string.Empty;
        public string CircularText { get; set; } = string.Empty;
        public List<CircularFilesDto>? CircularFiles { get; set; }
        public List<int>? CoordinatorId { get; set; }
        public List<int>? ArbitratorId { get; set; }
        public List<int>? ChairmanId { get; set; }
        public List<int>? SubcommitteeOfficerId { get; set; }
        public List<int>? ChairmanOfCommitteesId { get; set; }
        public List<int>? ExpertId { get; set; }
        public List<int>? QualityId { get; set; }
        public bool AllCoordinators {  get; set; }
        public bool AllArbitrators {  get; set; }
        public bool AllChairmans {  get; set; }
        public bool AllSubcommitteeOfficers {  get; set; }
        public bool AllChairmanOfCommittees {  get; set; }
        public bool AllExperts {  get; set; }
        public bool AllQualities {  get; set; }
        public string? lang {  get; set; }
        public string? token { get; set; }
    }
}
