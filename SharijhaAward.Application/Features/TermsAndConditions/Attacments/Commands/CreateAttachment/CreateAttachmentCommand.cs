using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Attacments.Commands.CreateAttachment
{
    public class CreateAttachmentCommand : IRequest<BaseResponse<object>>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IFormFile attachment { get; set; } = null!;
        public Guid TermAndConditionId { get; set; }
        public string? lang {get;set; } = string.Empty;
        public string token {  get; set; } = string.Empty;
    }
}
