namespace SharijhaAward.Application.Features.FilesManagementFeatures.Queries.ExportToExcel
{
    public class FilesExportToExcelListVM
    {
        public int Id { get; set; }
        public int? RowId { get; set; }
        public string FileName { get; set; } = null!;
        public DateTime UploadedAt { get; set; }
        public string? Description { get; set; }
        public string FileType { get; set; } = null!;
    }
}
