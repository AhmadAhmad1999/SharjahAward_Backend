using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ExtraAttachmentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExtraAttachments.Commands.UpdateExtraAttachment
{
    public class UpdateExtraAttachmentCommandHandler
         : IRequestHandler<UpdateExtraAttachmentCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ExtraAttachment> _extraAttachmentsRepository;
        private readonly IMapper _mapper;

        public UpdateExtraAttachmentCommandHandler(IAsyncRepository<ExtraAttachment> extraAttachmentsRepository, IMapper mapper)
        {
            _extraAttachmentsRepository = extraAttachmentsRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateExtraAttachmentCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Extra Attachment has been Updated"
                : "تم تعديل الملف الإضافي";

            var ExtraAttachment = await _extraAttachmentsRepository.GetByIdAsync(request.Id);
            if(ExtraAttachment == null)
            {
                msg = request.lang == "en"
                ? "Extra Attachment Not Found"
                : "الملف الإضافي غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            _mapper.Map(request, ExtraAttachment, typeof(UpdateExtraAttachmentCommand), typeof(ExtraAttachment));

            await _extraAttachmentsRepository.UpdateAsync(ExtraAttachment);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
