using MediatR;
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
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<ExtraAttachment> _ExtraAttachmentRepository;
        private readonly IAsyncRepository<ExtraAttachmentFile> _ExtraAttachmentFileRepository;
        
        public CheckAllExtraAttachmentQueryHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository,
            IAsyncRepository<ExtraAttachment> ExtraAttachmentRepository, 
            IAsyncRepository<ExtraAttachmentFile> ExtraAttachmentFileRepository)
        {
            _ProvidedFormRepository = ProvidedFormRepository;
            _ExtraAttachmentRepository = ExtraAttachmentRepository;
            _ExtraAttachmentFileRepository = ExtraAttachmentFileRepository;
        }

        public async Task<BaseResponse<object>> Handle(CheckAllExtraAttachmentQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.ProvidedFormModel.ProvidedForm? ProvidedFormEntity = await _ProvidedFormRepository
                .FirstOrDefaultAsync(x => x.Id == Request.formId);
           
            if (ProvidedFormEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Provided form is not found"
                    : "الإستمارة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            List<ExtraAttachment> ExtraAttachmentEntities = await _ExtraAttachmentRepository
                .Where(x => x.ProvidedFormId == ProvidedFormEntity.Id)
                .ToListAsync();

            List<ExtraAttachmentFile> AllExtraAttachmentFileEntities = await _ExtraAttachmentFileRepository
                .Where(x => ExtraAttachmentEntities.Select(y => y.Id).Contains(x.ExtraAttachmentId))
                .ToListAsync();

            foreach (ExtraAttachment ExtraAttachmentEntity in ExtraAttachmentEntities)
            {
                List<ExtraAttachmentFile> AllExtraAttachmentFileEntitiesForThisAttachment = AllExtraAttachmentFileEntities
                    .Where(x => x.ExtraAttachmentId == ExtraAttachmentEntity.Id)
                    .ToList();

                if (ExtraAttachmentEntity.RequiredAttachmentNumber < AllExtraAttachmentFileEntitiesForThisAttachment.Count())
                {
                    ResponseMessage = Request.lang == "en"
                        ? $"You can't upload more than {ExtraAttachmentEntity.RequiredAttachmentNumber} files"
                        : $"لا يمكنك رفع أكثر من {ExtraAttachmentEntity.RequiredAttachmentNumber} ملفات";

                    return new BaseResponse<object>(ResponseMessage, false, 400);
                }
                if (!AllExtraAttachmentFileEntitiesForThisAttachment.Any())
                {
                    ResponseMessage = Request.lang == "en"
                        ? $"You must upload at least on file for this extra attachment: {ExtraAttachmentEntity.EnglishTitle}"
                        : $"يجب رفع ملف واحد على الأقل للمرفق الإضافي: {ExtraAttachmentEntity.ArabicTitle}";

                    return new BaseResponse<object>(ResponseMessage, false, 400);
                }
            }

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
