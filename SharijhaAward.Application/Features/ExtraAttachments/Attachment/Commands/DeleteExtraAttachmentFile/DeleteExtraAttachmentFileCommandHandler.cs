using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ExtraAttachmentProvidedFormModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExtraAttachments.Attachment.Commands.DeleteExtraAttachmentFile
{
    public class DeleteExtraAttachmentFileCommandHandler
        : IRequestHandler<DeleteExtraAttachmentFileCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ExtraAttachmentFile> _ExtraAttachmentFileRepository;

        public DeleteExtraAttachmentFileCommandHandler(IAsyncRepository<ExtraAttachmentFile> extraAttachmentFileRepository)
        {
            _ExtraAttachmentFileRepository = extraAttachmentFileRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteExtraAttachmentFileCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "File has been Deleted"
                : "تم حذف الملف";
            var file = await _ExtraAttachmentFileRepository.GetByIdAsync(request.FileId);
            if (file == null)
            {
                msg = request.lang == "en"
                ? "File Not Found"
                : "الملف غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _ExtraAttachmentFileRepository.DeleteAsync(file);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
