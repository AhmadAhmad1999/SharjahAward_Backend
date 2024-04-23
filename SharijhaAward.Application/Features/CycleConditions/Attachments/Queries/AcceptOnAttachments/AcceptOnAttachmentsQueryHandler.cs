using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Attachments.Queries.AcceptOnAttachments
{
    public class AcceptOnAttachmentsQueryHandler
        : IRequestHandler<AcceptOnAttachmentsQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CycleConditionAttachment> _AttachmentRepository;
        
        public AcceptOnAttachmentsQueryHandler(IAsyncRepository<CycleConditionAttachment> _attachmentRepository)
        {
            _AttachmentRepository = _attachmentRepository;
        }
        public async Task<BaseResponse<object>> Handle(AcceptOnAttachmentsQuery request, CancellationToken cancellationToken)
        {
            var Attachment = await _AttachmentRepository.GetByIdAsync(request.AttachmentId);
            if(Attachment == null)
            {
                return new BaseResponse<object>("", false, 404);
            }
            Attachment.IsAccept = request.IsAccept;
            Attachment.ReasonOfReject = request.ReasonOfReject;

            await _AttachmentRepository.UpdateAsync(Attachment);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
