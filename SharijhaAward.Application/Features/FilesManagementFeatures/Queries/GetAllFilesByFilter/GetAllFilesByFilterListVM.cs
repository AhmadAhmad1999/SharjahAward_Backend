﻿namespace SharijhaAward.Application.Features.FilesManagementFeatures.Queries.GetAllFilesByFilter
{
    public class GetAllFilesByFilterListVM
    {
        public int Id { get; set; }
        public string FileName { get; set; } = null!;
        public int FileSizeInKB { get; set; }
        public DateTime UploadedAt { get; set; }
        public string? Description { get; set; }
        public int CycleId { get; set; }
        public string CycleName { get; set; } = null!;
    }
}
