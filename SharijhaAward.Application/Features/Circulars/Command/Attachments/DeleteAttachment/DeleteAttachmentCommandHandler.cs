using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CircularModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Circulars.Command.Attachments.DeleteAttachment
{
    public class DeleteAttachmentCommandHandler
        : IRequestHandler<DeleteAttachmentCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CircularAttachment> _circularAttachmentRepository;

        public DeleteAttachmentCommandHandler(IAsyncRepository<CircularAttachment> circularAttachmentRepository)
        {
            _circularAttachmentRepository = circularAttachmentRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteAttachmentCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "File Not Found"
                : "ملف التعميم غير موجود";

            var file = await _circularAttachmentRepository.GetByIdAsync(request.CircularFileId);
           
            if(file == null)
            {
                return new BaseResponse<object>(msg, false, 404);
            }

            await _circularAttachmentRepository.DeleteAsync(file);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
