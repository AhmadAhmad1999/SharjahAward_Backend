﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ExtraAttachmentModel;
using SharijhaAward.Domain.Entities.ExtraAttachmentProvidedFormModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExtraAttachments.Queries.CheckAllExtraAttachment
{
    public class CheckAllExtraAttachmentQueryHandler
        : IRequestHandler<CheckAllExtraAttachmentQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;
        private readonly IAsyncRepository<ExtraAttachment> _extraAttachmentRepository;
        private readonly IAsyncRepository<ExtraAttachmentFile> _extraAttachmentFileRepository;
        
        public CheckAllExtraAttachmentQueryHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository, IAsyncRepository<ExtraAttachment> extraAttachmentRepository, IAsyncRepository<ExtraAttachmentFile> extraAttachmentFileRepository)
        {
            _providedFormRepository = providedFormRepository;
            _extraAttachmentRepository = extraAttachmentRepository;
            _extraAttachmentFileRepository = extraAttachmentFileRepository;
        }

        public async Task<BaseResponse<object>> Handle(CheckAllExtraAttachmentQuery request, CancellationToken cancellationToken)
        {
            string msg= "";

            var form = await _providedFormRepository.FirstOrDefaultAsync(p => p.Id == request.formId);
           
            if (form == null)
            {
                msg = request.lang == "en"
                                ? "Provided Form Not Found"
                                : "لا يوجد إستمارة";

                return new BaseResponse<object>(msg, false, 404);
            }

            var extraAttachment = await _extraAttachmentRepository
                .Where(e => e.ProvidedFormId == form!.Id)
                .ToListAsync();

            List<ExtraAttachmentFile> AllExtraAttachmentFileEntities = await _extraAttachmentFileRepository
                .Where(x => extraAttachment.Select(y => y.Id).Contains(x.ExtraAttachmentId))
                .ToListAsync();

            foreach (var attachment in extraAttachment)
            {
                List<ExtraAttachmentFile> AllExtraAttachmentFileEntitiesForThisAttachment = AllExtraAttachmentFileEntities
                    .Where(x => x.ExtraAttachmentId == attachment.Id)
                    .ToList();

                if (attachment.RequiredAttachmentNumber < AllExtraAttachmentFileEntitiesForThisAttachment.Count())
                {
                    msg = request.lang == "en"
                        ? $"You can't upload more than {attachment.RequiredAttachmentNumber} files"
                        : $"لا يمكنك رفع أكثر من {attachment.RequiredAttachmentNumber} ملفات";

                    return new BaseResponse<object>(msg, false, 400);
                }
            }

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
