namespace SharijhaAward.Application.Features.Circulars.Queries.GetCircularById
{
    public class CircularDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string CircularText { get; set; } = string.Empty;
        public bool IsRead { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<CircularAttachmentDto>? CircularAttachments { get; set; }
        public List<int>? Coordinators { get; set; }
        public List<int>? Arbitrators { get; set; }
        public List<int>? Chairmans { get; set; }
        public List<int>? Experts { get; set; }
        public List<int>? Qualities { get; set; }
        public List<int>? ChairmanOfCommittes { get; set; }
        public List<int>? SubcommitteeOfficers { get; set; }
    }
}
