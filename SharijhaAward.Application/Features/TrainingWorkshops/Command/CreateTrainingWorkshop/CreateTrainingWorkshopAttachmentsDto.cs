using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Command.CreateTrainingWorkshop
{
    public class CreateTrainingWorkshopAttachmentsDto
    {
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        public IFormFile attachment { get; set; } = null!;
        public List<AttachmentType> AttachmentType { get; set; } = new List<AttachmentType>();
    }
}
