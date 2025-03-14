﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ExtraAttachmentModel;
using SharijhaAward.Domain.Entities.ExtraAttachmentProvidedFormModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

            var ExtraAttachment = await _extraAttachmentsRepository
                .Where(e => e.Id == request.ExtraAttachmentId)
                .FirstOrDefaultAsync();

            List<ExtraAttachmentFile> ExtraAttachmentsFileEntities = await _extraAttachmentsFileRepository
                .Where(x => x.ExtraAttachmentId == request.ExtraAttachmentId)
                .ToListAsync();

            if (ExtraAttachment == null)
            {
                msg = request.lang == "en"
                     ? "This Condition Not Found"
                     : "الشرط غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            if(ExtraAttachmentsFileEntities.Any(a => a.IsAccept == false))
            {
                var Attachment = await _extraAttachmentsFileRepository.FirstOrDefaultAsync(a => a.IsAccept == false);

                await _extraAttachmentsFileRepository.DeleteAsync(Attachment!);

                ExtraAttachmentsFileEntities.Remove(Attachment!);
            }

            if  (ExtraAttachment.RequiredAttachmentNumber > ExtraAttachmentsFileEntities.Count() ||
                ExtraAttachment.RequiredAttachmentNumber == 0)
            {
                var data = _mapper.Map<ExtraAttachmentFile>(request);

                data.IsAccept = null;

                data.FileUrl = await _fileService.SaveProvidedFormFilesAsync(request.File, ExtraAttachment.ProvidedFormId);

                await _extraAttachmentsFileRepository.AddAsync(data);

            }
            else
            {
                msg = request.lang == "en"
                    ? "You Can't Add More Files"
                    : "لا يمكنك رفع المزيد من الملفات";

                return new BaseResponse<object>(msg, false, 400);
            }



            return new BaseResponse<object>(msg, true, 200);
            
        }
    }
}
