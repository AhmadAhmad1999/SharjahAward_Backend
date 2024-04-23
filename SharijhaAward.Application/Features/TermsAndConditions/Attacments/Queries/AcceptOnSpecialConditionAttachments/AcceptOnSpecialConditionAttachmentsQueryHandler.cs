using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Attacments.Queries.AcceptOnSpecialConditionAttachments
{
    public class AcceptOnSpecialConditionAttachmentsQueryHandler
        : IRequestHandler<AcceptOnSpecialConditionAttachmentsQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ConditionAttachment> _conditionAttachmentRepository;

        public AcceptOnSpecialConditionAttachmentsQueryHandler(IAsyncRepository<ConditionAttachment> conditionAttachmentRepository)
        {
            _conditionAttachmentRepository = conditionAttachmentRepository;
        }

        public async Task<BaseResponse<object>> Handle(AcceptOnSpecialConditionAttachmentsQuery request, CancellationToken cancellationToken)
        {
            var Attachment = await _conditionAttachmentRepository.GetByIdAsync(request.AttachmentId);
            if (Attachment == null)
            {
                return new BaseResponse<object>("", false, 404);
            }
            Attachment.IsAccept = request.IsAccept;
            Attachment.ReasonOfReject = request.ReasonOfReject;

            await _conditionAttachmentRepository.UpdateAsync(Attachment);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
