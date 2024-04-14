using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Commands.CreateTermAndCondition
{
    public class CreateTermAndConditionCommand : IRequest<BaseResponse<object>>
    {
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public bool NeedAttachment { get; set; } = false;
        public bool? IsSpecial { get; set; } = true;
        public int? RequiredAttachmentNumber { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public AttachmentType? AttachmentType { get; set; }
        public bool IsAgree { get; set; } = false;
        public int CategoryId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
