using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TrainingWrokshopeAttachments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Attacments.Commands.DeleteWorkshopAttachment
{
    public class DeleteWorkshopAttachmentCommandHandler
        : IRequestHandler<DeleteWorkshopAttachmentCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<TrainingWrokshopeAttachment> _attachmentRepository;
        
        public DeleteWorkshopAttachmentCommandHandler(IAsyncRepository<TrainingWrokshopeAttachment> attachmentRepository)
        {
            _attachmentRepository = attachmentRepository;
        }
        public async Task<BaseResponse<object>> Handle(DeleteWorkshopAttachmentCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Workshop Attachment has been Deleted"
                : "تم حذف ملف الورشة التدريبية";

            var Attachment = await _attachmentRepository.GetByIdAsync(request.Id);
            if(Attachment == null) 
            {
                msg = request.lang == "en"
                    ? "Workshop Attachment Not Found"
                    : "ملف الورشة غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _attachmentRepository.DeleteAsync(Attachment);

            return new BaseResponse<object>(msg, true, 200);

        }
    }
}
