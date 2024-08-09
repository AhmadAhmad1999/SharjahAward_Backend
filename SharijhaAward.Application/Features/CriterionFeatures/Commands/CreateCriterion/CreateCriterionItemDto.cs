using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterion
{
    public class CreateCriterionItemDto
    {
        // [ArabicNameValidation(ErrorMessage = "Arabic name must only contain Arabic characters.")]
        public string ArabicName { get; set; } = string.Empty;
        // [EnglishNameValidation(ErrorMessage = "English name must only contain English characters.")]
        public string EnglishName { get; set; } = string.Empty;
        public int Score { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public int MaxAttachmentNumber { get; set; }
        public AttachmentType AttachmentType { get; set; }
        // public int ActualScore { get; set; }
        //public int CriterionId { get; set; } // We Can Get This Id From The CreateSubCriterionDto Object After Add It To The Database..
    }
}
