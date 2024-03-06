using AutoMapper;
using MediatR;
using Microsoft.VisualBasic;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Attacments.Commands.CreateAttachment
{
    public class CreateAttachmentCommandHandler
        : IRequestHandler<CreateAttachmentCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ConditionsAttachment> _attachmentsRepository;
        private readonly IAsyncRepository<TermAndCondition> _termsRepository;
        private readonly IFileService<ConditionsAttachment> _attachmentFileService;
        private readonly IMapper _mapper;

        public CreateAttachmentCommandHandler
            (
                 IAsyncRepository<ConditionsAttachment> attachmentsRepository,
                 IFileService<ConditionsAttachment> attachmentFileService,
                 IAsyncRepository<TermAndCondition> termsRepository,
                 IMapper mapper
            )
        {
            _attachmentsRepository = attachmentsRepository;
            _attachmentFileService = attachmentFileService;
            _termsRepository = termsRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateAttachmentCommand request, CancellationToken cancellationToken)
        {
            var term = _termsRepository.WhereThenInclude(t => t.Id == request.TermAndConditionId, t => t.Attachments).FirstOrDefault();
            string msg;
            if (term == null)
            {
                msg = request.lang == "en"
                    ? "The TermAndCondition Not Found"
                    : "الشرط غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }
            var data = _mapper.Map<ConditionsAttachment>(request);
          
            if(term.NeedAttachment)
            {
                if (term.RequiredAttachmentNumber > term.Attachments.Count || term.RequiredAttachmentNumber == 0)
                {
                    data.AttachementPath = await _attachmentFileService.SaveFileAsync(request.attachment);
                    await _attachmentsRepository.AddAsync(data);
                }
                else
                {
                    msg = request.lang == "en"
                       ? "You Can't Upload file"
                       : "لا يمكنك رفع المزيد من الملفات";

                    return new BaseResponse<object>(msg, true, 400);
                }
            }

            return new BaseResponse<object>("", true, 200);
        }
    }
}

