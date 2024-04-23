using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ExtraAttachmentProvidedFormModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExtraAttachments.Attachment.Queries.AcceptOnExtraAttachmentFiles
{
    public class AcceptOnExtraAttachmentFilesQueryHandler
        : IRequestHandler<AcceptOnExtraAttachmentFilesQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ExtraAttachmentFile> _attachmentFileRepository;

        public AcceptOnExtraAttachmentFilesQueryHandler(IAsyncRepository<ExtraAttachmentFile> attachmentFileRepository)
        {
            _attachmentFileRepository = attachmentFileRepository;
        }

        public async Task<BaseResponse<object>> Handle(AcceptOnExtraAttachmentFilesQuery request, CancellationToken cancellationToken)
        {
            var Attachment = await _attachmentFileRepository.GetByIdAsync(request.AttachmentId);
            if (Attachment == null)
            {
                return new BaseResponse<object>("", false, 404);
            }
            Attachment.IsAccept = request.IsAccept;
            Attachment.ReasonOfReject = request.ReasonOfReject;

            await _attachmentFileRepository.UpdateAsync(Attachment);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
