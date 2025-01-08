namespace SharijhaAward.Application.Features.FilesManagementFeatures.Queries.GetAllFilesByFilter
{
    public class GetAllFilesByFilterListVM
    {
        public int Id { get; set; }
        public int? RowId { get; set; }
        public string FileName { get; set; } = null!;
        public int FileSizeInKB { get; set; }
        public DateTime UploadedAt { get; set; }
        public string? Description { get; set; }
        public string FileType { get; set; } = null!;
        public int? FormId { get; set; }
        public string? SubscriberId { get; set; }
        public int? CycleNumber { get; set; }
        public string? CategoryName { get; set; }
        public int? UserId { get; set; }
        public string? CoordinatorName { get; set; }
        public string? ArbitratorName { get; set; }
    }
}
