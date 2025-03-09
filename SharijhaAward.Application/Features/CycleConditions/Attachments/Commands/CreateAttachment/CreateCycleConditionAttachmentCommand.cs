using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.CycleConditions.Attachments.Commands.CreateAttachment
{
    public class CreateCycleConditionAttachmentCommand : IRequest<BaseResponse<object>>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IFormFile attachment { get; set; } = null!;
        public int CycleConditionId { get; set; }
        public string? lang { get; set; } = string.Empty;
        public string token { get; set; } = string.Empty;
        public int formId { get; set; }
    }
}
