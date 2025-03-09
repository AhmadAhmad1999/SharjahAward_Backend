using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetWorkShopsByCategoryId
{
    public  class WorkshopAttachmentListVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        public string AttachementURl { get; set; } = string.Empty;
        public int SizeOfAttachmentInKB { get; set; }
        public List<AttachmentType> AttachmentType { get; set; } = new List<AttachmentType>();
    }
}
