using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Attacments.Commands.CreateWorkshpoeAttachment
{
    public class CreateWorkshopeAttachmentCommand : IRequest<BaseResponse<object>>
    {
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;
        public IFormFile attachment { get; set; } = null!;
        public AttachmentType AttachmentType { get; set; }
        public int WorkshopeId { get; set; }
    }
}
