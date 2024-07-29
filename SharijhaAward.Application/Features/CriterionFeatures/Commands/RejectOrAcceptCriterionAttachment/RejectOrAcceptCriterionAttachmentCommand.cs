using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.RejectOrAcceptCriterionAttachment
{
    public class RejectOrAcceptCriterionAttachmentCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string? ReasonForRejecting { get; set; }
        public string? lang { get; set; }
    }
}
