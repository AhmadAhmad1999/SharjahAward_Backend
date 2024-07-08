using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Attachments.Commands.CreateAttachment
{
    public class CreateCycleConditionAttachmentCommandHandler
        : IRequestHandler<CreateCycleConditionAttachmentCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CycleConditionAttachment> _attachmentsRepository;
        private readonly IAsyncRepository<CycleCondition> _termsRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formsRepository;
        private readonly IAsyncRepository<CycleConditionsProvidedForm> _conditionFormsRepository;
        private readonly IFileService _attachmentFileService;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public CreateCycleConditionAttachmentCommandHandler(IAsyncRepository<CycleConditionAttachment> attachmentsRepository, IAsyncRepository<CycleCondition> termsRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formsRepository, IAsyncRepository<CycleConditionsProvidedForm> conditionFormsRepository, IFileService attachmentFileService, IJwtProvider jwtProvider, IMapper mapper)
        {
            _attachmentsRepository = attachmentsRepository;
            _termsRepository = termsRepository;
            _formsRepository = formsRepository;
            _conditionFormsRepository = conditionFormsRepository;
            _attachmentFileService = attachmentFileService;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateCycleConditionAttachmentCommand request, CancellationToken cancellationToken)
        {
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            var form = _formsRepository.FirstOrDefault(f => f.userId == int.Parse(UserId) && f.Id == request.formId);
            var term = _termsRepository.WhereThenInclude(t => t.Id == request.CycleConditionId, t => t.ConditionAttachments).FirstOrDefault();

            string msg;

            if (term == null)
            {
                msg = request.lang == "en"
                    ? "The TermAndCondition Not Found"
                    : "الشرط غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            var conditionsProvided = _conditionFormsRepository
                .WhereThenInclude(c => c.CycleConditionId == term.Id
                && c.ProvidedFormId == form!.Id,
                c => c.Attachments).FirstOrDefault();

            if(conditionsProvided == null)
            {
                conditionsProvided = new CycleConditionsProvidedForm()
                {
                    IsAgree = false,
                    ProvidedFormId = request.formId,
                    CycleConditionId = request.CycleConditionId
                };
                conditionsProvided = await _conditionFormsRepository.AddAsync(conditionsProvided);
            }


            var data = _mapper.Map<CycleConditionAttachment>(request);
            data.CycleConditionsProvidedFormId = conditionsProvided!.Id;

            if (term.NeedAttachment)
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
