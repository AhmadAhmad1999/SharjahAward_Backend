using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ExtraAttachmentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExtraAttachments.Commands.DeleteExtraAttachment
{
    public class DeleteExtraAttachmentCommandHandler
        : IRequestHandler<DeleteExtraAttachmentCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ExtraAttachment> _extraAttachmentsRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formModelRepository;

        public DeleteExtraAttachmentCommandHandler(IAsyncRepository<ExtraAttachment> extraAttachmentsRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formModelRepository)
        {
            _extraAttachmentsRepository = extraAttachmentsRepository;
            _formModelRepository = formModelRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteExtraAttachmentCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Extra Attachment has been Deleted"
                : "تم حذف الملف الإضافي";

            var ExtraAttachment = await _extraAttachmentsRepository.GetByIdAsync(request.Id);
            if (ExtraAttachment == null)
            {
                msg = request.lang == "en"
                ? "Extra Attachment Not Found"
                : "الملف الإضافي غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }
            await _extraAttachmentsRepository.DeleteAsync(ExtraAttachment);

            int countOfExtraAttachment = _extraAttachmentsRepository.GetCount(e => e.ProvidedFormId == ExtraAttachment.ProvidedFormId && !e.isDeleted);

            if (countOfExtraAttachment == 0)
            {
                var form = await _formModelRepository.GetByIdAsync(ExtraAttachment.ProvidedFormId);
                if (form == null)
                {
                    msg = request.lang == "en"
                    ? "Provided Form is not Found"
                    : "الإستمارة غير موجودة";

                    return new BaseResponse<object>(msg, false, 404);
                }
                form.TotalStep = 7;
                form.PercentCompletion = 100;

                await _formModelRepository.UpdateAsync(form);
            }
            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
