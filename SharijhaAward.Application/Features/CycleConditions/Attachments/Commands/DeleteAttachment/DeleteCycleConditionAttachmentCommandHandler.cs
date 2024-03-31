using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Attachments.Commands.DeleteAttachment
{
    public class DeleteCycleConditionAttachmentCommandHandler
        : IRequestHandler<DeleteCycleConditionAttachmentCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CycleConditionAttachment> _attachmentsRepository;
       
        public DeleteCycleConditionAttachmentCommandHandler(IAsyncRepository<CycleConditionAttachment> attachmentsRepository)
        {
            _attachmentsRepository = attachmentsRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteCycleConditionAttachmentCommand request, CancellationToken cancellationToken)
        {
            var attachment = await _attachmentsRepository.GetByIdAsync(request.AttachmentId);
            if (attachment == null)
            {
                return new BaseResponse<object>("", false, 404);
            }
            await _attachmentsRepository.DeleteAsync(attachment);
            return new BaseResponse<object>("", true, 200);
        }
    }
}
