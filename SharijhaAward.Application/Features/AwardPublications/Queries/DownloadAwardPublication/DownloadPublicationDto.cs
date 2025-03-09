namespace SharijhaAward.Application.Features.AwardPublications.Queries.DownloadAwardPublication
{
    public class DownloadPublicationDto
    {
        public byte[] fileContent { get; set; } = null!;
        public string fileContentType { get; set; } = null!;
        public string fileFileName { get; set; } = string.Empty;
    }
}
