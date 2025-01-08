using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.FilesManagementFeatures.Queries.GetAllFilesByFilter
{
    public class GetAllFilesByFilterQuery : IRequest<BaseResponse<List<GetAllFilesByFilterListVM>>>
    {
        public int FilterId { get; set; }
        public string? lang { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public string? wwwRootFilePath { get; set; }
        public int? FormId { get; set; }
        public string? SubscriberId { get; set; }
        public int? CycleId { get; set; }
        public int? CategoryId { get; set; }
        public int? UserId { get; set; }
        public string? CoordinatorName { get; set; }
        public string? ArbitratorName { get; set; }
    }
}
