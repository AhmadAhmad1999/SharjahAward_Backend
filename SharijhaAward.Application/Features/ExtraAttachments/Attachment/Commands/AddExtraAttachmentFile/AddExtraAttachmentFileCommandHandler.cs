using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ExtraAttachmentModel;
using SharijhaAward.Domain.Entities.ExtraAttachmentProvidedFormModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExtraAttachments.Attachment.Commands.AddExtraAttachmentFile
{
    public class AddExtraAttachmentFileCommandHandler
        : IRequestHandler<AddExtraAttachmentFileCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ExtraAttachmentFile> _extraAttachmentsFileRepository;
        private readonly IAsyncRepository<ExtraAttachment> _extraAttachmentsRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public AddExtraAttachmentFileCommandHandler(IFileService fileService, IAsyncRepository<ExtraAttachmentFile> extraAttachmentsFileRepository, IAsyncRepository<ExtraAttachment> extraAttachmentsRepository, IMapper mapper)
        {
            _extraAttachmentsFileRepository = extraAttachmentsFileRepository;
            _extraAttachmentsRepository = extraAttachmentsRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(AddExtraAttachmentFileCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                       ? "File has been Uploaded"
                       : "تم رفع الملف بنجاح";

            var ExtraAttachment = await _extraAttachmentsRepository.GetByIdAsync(request.ExtraAttachmentId);
            if(ExtraAttachment == null)
            {
                msg = request.lang == "en"
                     ? "This Condition Not Found"
                     : "الشرط غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }
            var data = _mapper.Map<ExtraAttachmentFile>(request);

            data.FileUrl = await _fileService.SaveProvidedFormFilesAsync(request.File, ExtraAttachment.ProvidedFormId);

            await _extraAttachmentsFileRepository.AddAsync(data);

            return new BaseResponse<object>(msg, true, 200);
            
        }
    }
}
