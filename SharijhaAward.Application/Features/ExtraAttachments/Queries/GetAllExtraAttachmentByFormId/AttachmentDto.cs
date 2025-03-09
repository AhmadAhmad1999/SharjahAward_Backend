namespace SharijhaAward.Application.Features.ExtraAttachments.Queries.GetAllExtraAttachmentByFormId
{
    public class AttachmentDto
    {
        public int Id { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string FileDescription { get; set; } = string.Empty;
        public string FileUrl { get; set; } = string.Empty;
        public bool? IsAccept { get; set; }
        public string? ReasonOfReject { get; set; }
    }
}
