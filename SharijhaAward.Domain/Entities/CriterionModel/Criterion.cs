using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Domain.Entities.CriterionModel
{
    public class Criterion : AuditableEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public int Score { get; set; }
        public int SizeOfAttachmentInKB { get; set; }
        public int? ParentId { get; set; }
        public Criterion? Parent { get; set; } = null!;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public int? MaxAttachmentNumber { get; set; }
        public AttachmentType? AttachmentType { get; set; }
        public bool? AttachFilesOnSubCriterion { get; set; }
    }
}

