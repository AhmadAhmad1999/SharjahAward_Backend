namespace SharijhaAward.Application.Features.Circulars.Queries.GetCircularById
{
    public class CircularAttachmentDto
    {
        public int Id { get; set; }
        public string FileName { get; set; } = null!;
        public string AttachementPath { get; set; } = string.Empty;
        public int CircularId { get; set; }
    }
}
