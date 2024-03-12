using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterionItemAttachment
{
    public class CreateCriterionItemAttachmentCommand : IRequest<BaseResponse<object>>
    {
        public Guid CriterionItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IFormFile Attachment { get; set; } = null!;
        public string? lang { get; set; } = string.Empty;
    }
}
