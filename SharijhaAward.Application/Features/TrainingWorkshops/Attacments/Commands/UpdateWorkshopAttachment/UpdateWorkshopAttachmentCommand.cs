using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Attacments.Commands.UpdateWorkshopAttachment
{
    public class UpdateWorkshopAttachmentCommand : IRequest<BaseResponse<object>>
    {
        public Guid Id {  get; set; }
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;
        public IFormFile attachment { get; set; } = null!;
        public bool EditOnAttachment {  get; set; } = false;
        public AttachmentType AttachmentType { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
