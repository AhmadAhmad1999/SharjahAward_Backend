using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
        private readonly IAsyncRepository<ConditionAttachment> _ConditionAttachmentRepository;
        private readonly IAsyncRepository<TermAndCondition> _TermAndConditionRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<ConditionsProvidedForms> _ConditionsProvidedFormsRepository;
        private readonly IFileService _FileService;
        private readonly IJwtProvider _JwtProvider;
        private readonly IMapper _Mapper;

        public CreateAttachmentCommandHandler(IAsyncRepository<ConditionAttachment> _ConditionAttachmentRepository,
            IAsyncRepository<TermAndCondition> _TermAndConditionRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository,
            IAsyncRepository<ConditionsProvidedForms> _ConditionsProvidedFormsRepository,
            IFileService _FileService,
            IJwtProvider _JwtProvider,
            IMapper _Mapper)
        {
            this._ConditionAttachmentRepository = _ConditionAttachmentRepository;
            this._TermAndConditionRepository = _TermAndConditionRepository;
            this._ProvidedFormRepository = _ProvidedFormRepository; 
            this._ConditionsProvidedFormsRepository = _ConditionsProvidedFormsRepository;
            this._FileService = _FileService;
            this._JwtProvider = _JwtProvider;
            this._Mapper = _Mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateAttachmentCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;
            
            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.token));
            
            Domain.Entities.ProvidedFormModel.ProvidedForm? ProvidedFormEntity = _ProvidedFormRepository
                .FirstOrDefault(x => x.userId == UserId && x.Id == Request.formId);

            TermAndCondition? TermAndConditionEntity = await _TermAndConditionRepository
                .FirstOrDefaultAsync(t => t.Id == Request.TermAndConditionId);
           
            if (TermAndConditionEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Term and condition is not found"
                    : "الشرط غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            ConditionsProvidedForms? ConditionsProvidedFormsEntity = await _ConditionsProvidedFormsRepository
                .FirstOrDefaultAsync(c => c.TermAndConditionId == TermAndConditionEntity.Id &&
                    c.ProvidedFormId == ProvidedFormEntity!.Id);

            List<ConditionAttachment> AttachmentsEntities = new List<ConditionAttachment>();
            
            if (ConditionsProvidedFormsEntity != null)
            {
                AttachmentsEntities = await _ConditionAttachmentRepository
                    .Where(x => x.ConditionsProvidedFormsId == ConditionsProvidedFormsEntity.Id)
                    .ToListAsync();

                if (AttachmentsEntities.Any())
                {
                    var Attachment = AttachmentsEntities.Where(a => a.IsAccept == false);

                    if (Attachment != null)
                        await _ConditionAttachmentRepository.DeleteListAsync(Attachment!);
                }
            }

            if (ConditionsProvidedFormsEntity == null)
            {
                ConditionsProvidedFormsEntity = new ConditionsProvidedForms()
                {
                    IsAgree = false,
                    ProvidedFormId = Request.formId,
                    TermAndConditionId = Request.TermAndConditionId

                };

                await _ConditionsProvidedFormsRepository.AddAsync(ConditionsProvidedFormsEntity);
            }

            ConditionAttachment ConditionAttachment = _Mapper.Map<ConditionAttachment>(Request);
            ConditionAttachment.ConditionsProvidedFormsId = ConditionsProvidedFormsEntity!.Id;
          
            if(TermAndConditionEntity.NeedAttachment)
            {
                if (TermAndConditionEntity.RequiredAttachmentNumber > AttachmentsEntities.Count() || TermAndConditionEntity.RequiredAttachmentNumber == 0)
                {
                    ConditionAttachment.AttachementPath = await _FileService.SaveProvidedFormFilesAsync(Request.attachment, ProvidedFormEntity!.Id);

                    await _ConditionAttachmentRepository.AddAsync(ConditionAttachment);
                }
                else
                {
                    ResponseMessage = Request.lang == "en"
                       ? "You can't upload more files"
                       : "لا يمكنك رفع المزيد من الملفات";

                    return new BaseResponse<object>(ResponseMessage, true, 400);
                }
            }

            return new BaseResponse<object>("", true, 200);
        }
    }
}

