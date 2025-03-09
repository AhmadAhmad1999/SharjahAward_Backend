using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.ExportToExcel
{
    public class TermExportDto
    {
        public int Id { get; set; }
        public string? ArabicDescription { get; set; } = string.Empty;
        public string? EnglishDescription { get; set; } = string.Empty;
        public bool? IsSpecial { get; set; } = false;
        public bool NeedAttachment { get; set; } = false;
        public int? RequiredAttachmentNumber { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public List<AttachmentType> Type { get; set; } = new List<AttachmentType>();
    }
}
