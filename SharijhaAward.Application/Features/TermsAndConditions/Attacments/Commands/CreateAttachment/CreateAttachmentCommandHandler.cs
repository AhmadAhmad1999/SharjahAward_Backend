using AutoMapper;
using MediatR;
using Microsoft.VisualBasic;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
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
        private readonly IAsyncRepository<ConditionAttachment> _attachmentsRepository;
        private readonly IAsyncRepository<TermAndCondition> _termsRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formsRepository;
        private readonly IAsyncRepository<ConditionsProvidedForms> _conditionFormsRepository;
        private readonly IFileService _attachmentFileService;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public CreateAttachmentCommandHandler
            (
                 IAsyncRepository<ConditionAttachment> attachmentsRepository,
                 IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formsRepository,
                 IAsyncRepository<TermAndCondition> termsRepository,
                 IAsyncRepository<ConditionsProvidedForms> conditionFormsRepository,
                 IFileService attachmentFileService,
                 IJwtProvider jwtProvider,
                 IMapper mapper
            )
        {
            _attachmentsRepository = attachmentsRepository;
            _attachmentFileService = attachmentFileService;
            _conditionFormsRepository = conditionFormsRepository;
            _formsRepository = formsRepository; 
            _termsRepository = termsRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateAttachmentCommand request, CancellationToken cancellationToken)
        {
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            var form = _formsRepository.FirstOrDefault(f => f.userId == int.Parse(UserId) && f.Id == request.formId);
            var term = _termsRepository.WhereThenInclude(t => t.Id == request.TermAndConditionId, t => t.ConditionAttachments).FirstOrDefault();
           
            string msg;
           
            if (term == null)
            {
                msg = request.lang == "en"
                    ? "The TermAndCondition Not Found"
                    : "الشرط غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }
            
            var conditionsProvided = _conditionFormsRepository
                .WhereThenInclude(c => c.TermAndConditionId == term.Id 
                && c.ProvidedFormId == form!.Id ,
                c=>c.Attachments).FirstOrDefault();

            if (conditionsProvided != null && conditionsProvided!.Attachments.Any(a => a.IsAccept == false))
            {
                var Attachment = conditionsProvided
                    .Attachments.Where(a => a.IsAccept == false).FirstOrDefault();

                await _attachmentsRepository.DeleteAsync(Attachment!);

                conditionsProvided.Attachments.Remove(Attachment!);
            }


            if (conditionsProvided == null)
            {
                conditionsProvided = new ConditionsProvidedForms()
                {
                    IsAgree = false,
                    ProvidedFormId = request.formId,
                    TermAndConditionId = request.TermAndConditionId

                };
                await _conditionFormsRepository.AddAsync(conditionsProvided);
            }

            var data = _mapper.Map<ConditionAttachment>(request);
            data.ConditionsProvidedFormsId = conditionsProvided!.Id;
          
            if(term.NeedAttachment)
            {
                if (term.RequiredAttachmentNumber > conditionsProvided.Attachments.Count || term.RequiredAttachmentNumber == 0)
                {
                    data.AttachementPath = await _attachmentFileService.SaveProvidedFormFilesAsync(request.attachment, form!.Id);

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

