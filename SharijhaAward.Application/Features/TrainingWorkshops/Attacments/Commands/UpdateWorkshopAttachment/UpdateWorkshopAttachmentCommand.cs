using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Attacments.Commands.UpdateWorkshopAttachment
{
    public class UpdateWorkshopAttachmentCommand : IRequest<BaseResponse<object>>
    {
        public int Id {  get; set; }
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        public IFormFile? attachment { get; set; } = null!;
        public bool EditOnAttachment {  get; set; } = false;
        public List<AttachmentType> AttachmentType { get; set; } = new List<AttachmentType>();
        public string lang { get; set; } = string.Empty;
    }
}
