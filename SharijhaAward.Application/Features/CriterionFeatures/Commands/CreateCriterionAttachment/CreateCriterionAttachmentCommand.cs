using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterionAttachment
{
    public class CreateCriterionAttachmentCommand : IRequest<BaseResponse<object>>
    {
        public int CriterionId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IFormFile Attachment { get; set; } = null!;
        public int ProvidedFormId { get; set; }
        public string? lang { get; set; } = string.Empty;
    }
}
