using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ExtraAttachments.Queries.GetAllExtraAttachment
{
    public class GetAllExtraAttachmentByFormIdQuery : IRequest<BaseResponse<List<ExtraAttachmentListVM>>>
    {
        public int formId { get; set; }
        public string lang { get; set; } = string.Empty;
        public bool GetOnlyTheRequests { get; set; }
    }
}
