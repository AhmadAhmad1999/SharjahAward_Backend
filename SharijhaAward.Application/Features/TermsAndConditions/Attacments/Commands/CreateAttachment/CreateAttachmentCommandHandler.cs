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
            var form = _formsRepository.Where(f => f.userId== new Guid(UserId)).FirstOrDefault();
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
                .Where(c => c.TermAndConditionId == term.Id)
                .Where(c => c.ProvidedFormId == form!.Id).FirstOrDefault();

            if(conditionsProvided == null)
            {
                conditionsProvided = new ConditionsProvidedForms()
                {
                    ProvidedFormId = form!.Id,
                    TermAndConditionId = term!.Id,
                };
                conditionsProvided = await _conditionFormsRepository.AddAsync(conditionsProvided);
            }
           
            var data = _mapper.Map<ConditionAttachment>(request);
            data.ConditionsProvidedFormsId = conditionsProvided.Id;
          
            if(term.NeedAttachment)
            {
                if (term.RequiredAttachmentNumber > term.ConditionAttachments.Count || term.RequiredAttachmentNumber == 0)
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

