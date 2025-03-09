using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionsForDashBoardByCategoryId
{
    public class GetAllSubCriterionItems
    {
        public int Id { get; set; }
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        public int Score { get; set; }
        public int SizeOfAttachmentInKB { get; set; }
        public int MaxAttachmentNumber { get; set; }
        public List<AttachmentType> AttachmentType { get; set; } = new List<AttachmentType>();
    }
}
