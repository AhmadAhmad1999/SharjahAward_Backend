using MediatR;
using SharijhaAward.Application.Features.FilesManagementFeatures.Queries.GetAllFilesByFilter;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.FilesManagementFeatures.Queries.DownloadFilesByIds
{
    public class DownloadFilesByIdsQuery : IRequest<BaseResponse<List<DownloadFilesByIdsListVM>>>
    {
        public List<int> Ids { get; set; } = new List<int>();
        public bool DownloadAllFiles { get; set; } = false;
        public FilesFilter Filter { get; set; }
        public string? lang { get; set; }
    }
}
