using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;

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

            var term = _termsRepository
                .FirstOrDefault(t => t.Id == request.CycleConditionId);

            string msg;

            if (term == null)
            {
                msg = request.lang == "en"
                    ? "The Term And Condition Not Found"
                    : "الشرط غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            var conditionsProvided = await _conditionFormsRepository
                .FirstOrDefaultAsync(c => c.CycleConditionId == term.Id &&
                    c.ProvidedFormId == form!.Id);

            var data = _mapper.Map<CycleConditionAttachment>(request);

            List<CycleConditionAttachment> AttachmentsEntities = new List<CycleConditionAttachment>();

            if (conditionsProvided != null)
            {
                AttachmentsEntities = await _attachmentsRepository
                    .Where(x => x.CycleConditionsProvidedFormId == conditionsProvided!.Id)
                    .ToListAsync();

                if (AttachmentsEntities.Any(a => a.IsAccept == false))
                {
                    var Attachment = AttachmentsEntities.FirstOrDefault(a => a.IsAccept == false);

                    await _attachmentsRepository.DeleteAsync(Attachment!);

                    AttachmentsEntities.Remove(Attachment!);
                }
            }
            else
            {
                conditionsProvided = new CycleConditionsProvidedForm()
                {
                    IsAgree = false,
                    ProvidedFormId = request.formId,
                    CycleConditionId = request.CycleConditionId
                };

                conditionsProvided = await _conditionFormsRepository.AddAsync(conditionsProvided);
            }

            data.CycleConditionsProvidedFormId = conditionsProvided!.Id;

            if (term.NeedAttachment)
            {
                if (term.RequiredAttachmentNumber > AttachmentsEntities.Count() || term.RequiredAttachmentNumber == 0)
                {
                    data.AttachementPath = await _attachmentFileService.SaveProvidedFormFilesAsync(request.attachment, form!.Id);
                    data.IsAccept = null;
                    data.ReasonOfReject = null;

                    await _attachmentsRepository.AddAsync(data);
                }
                else
                {
                    msg = request.lang == "en"
                       ? "You can't upload more files"
                       : "لا يمكنك رفع المزيد من الملفات";

                    return new BaseResponse<object>(msg, true, 400);
                }
            }

            return new BaseResponse<object>("", true, 200);
        }
    }
}
