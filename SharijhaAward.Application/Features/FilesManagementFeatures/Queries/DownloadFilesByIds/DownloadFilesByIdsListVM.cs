namespace SharijhaAward.Application.Features.FilesManagementFeatures.Queries.DownloadFilesByIds
{
    public class DownloadFilesByIdsListVM
    {
        public string FilePath { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public bool isDynamic { get; set; } = false;
    }
}
