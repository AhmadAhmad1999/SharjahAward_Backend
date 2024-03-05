using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Attacments.Commands.DeleteAttachment
{
    public class DeleteAttachmentCommandHandler 
        : IRequestHandler<DeleteAttachmentCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ConditionsAttachment> _attachmentsRepository;

        public DeleteAttachmentCommandHandler(IAsyncRepository<ConditionsAttachment> attachmentsRepository)
        {
            _attachmentsRepository = attachmentsRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteAttachmentCommand request, CancellationToken cancellationToken)
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
