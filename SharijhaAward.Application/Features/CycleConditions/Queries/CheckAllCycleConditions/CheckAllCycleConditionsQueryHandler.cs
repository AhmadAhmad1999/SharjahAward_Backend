using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.CheckAllCycleConditions
{
    public class CheckAllCycleConditionsQueryHandler
        : IRequestHandler<CheckAllCycleConditionsQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CycleConditionAttachment> _CycleConditionAttachmentRepository;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IAsyncRepository<CycleCondition> _CycleConditionRepository;
        private readonly IAsyncRepository<CycleConditionsProvidedForm> _CycleConditionsProvidedFormRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;

        public CheckAllCycleConditionsQueryHandler(IAsyncRepository<CycleConditionAttachment> _CycleConditionAttachmentRepository, 
            IAsyncRepository<Cycle> _CycleRepository,
            IAsyncRepository<CycleCondition> _CycleConditionRepository, 
            IAsyncRepository<CycleConditionsProvidedForm> _CycleConditionsProvidedFormRepository, 
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository)
        {
            this._CycleConditionAttachmentRepository = _CycleConditionAttachmentRepository;
            this._CycleRepository = _CycleRepository;
            this._CycleConditionRepository = _CycleConditionRepository;
            this._CycleConditionsProvidedFormRepository = _CycleConditionsProvidedFormRepository;
            this._ProvidedFormRepository = _ProvidedFormRepository;
        }

        public async Task<BaseResponse<object>> Handle(CheckAllCycleConditionsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Cycle? CycleEntity = await _CycleRepository
                .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

            if(CycleEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "There is no active cycle"
                    : "لا يوجد دورات فعالة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (CycleEntity.Status == Domain.Constants.Common.Status.Close)
            {
                ResponseMessage = Request.lang == "en"
                    ? "The status of cycle is close"
                    : "حالة الدورة مغلقة";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            Domain.Entities.ProvidedFormModel.ProvidedForm? ProvidedFormEntity = await _ProvidedFormRepository
                .FirstOrDefaultAsync(x => x.Id == Request.formId);

            List<CycleCondition> CycleConditionEntities = await _CycleConditionRepository
                .Where(t => t.CycleId == CycleEntity.Id)
                .ToListAsync();

            if (CycleConditionEntities.Any())
            {
                List<CycleConditionsProvidedForm> CycleConditionsProvidedFormEntities = await _CycleConditionsProvidedFormRepository
                    .Where(x => CycleConditionEntities.Select(y => y.Id).Contains(x.CycleConditionId) &&
                        x.ProvidedFormId == ProvidedFormEntity!.Id)
                    .ToListAsync();

                if (CycleConditionsProvidedFormEntities.Any(x => !x.IsAgree &&
                    !x.CycleCondition!.NeedAttachment))
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Pleas agree on all terms and conditions"
                        : "الرجاء الموافقة على جميع الشروط و الأحكام";

                    return new BaseResponse<object>(ResponseMessage, false, 400);
                }

                List<CycleConditionAttachment> CycleConditionAttachmentEntities = await _CycleConditionAttachmentRepository
                    .Where(x => CycleConditionEntities.Select(y => y.Id).Contains(x.CycleConditionsProvidedForm!.CycleConditionId) &&
                        x.CycleConditionsProvidedForm!.ProvidedFormId == ProvidedFormEntity!.Id)
                    .ToListAsync();

                int TotalCycleConditionsThatNeedAttachment = CycleConditionEntities
                    .Count(x => x.NeedAttachment);

                if (CycleConditionAttachmentEntities != null
                    ? CycleConditionAttachmentEntities.Any()
                    : false)
                {
                    int TotalAttachmentsCount = CycleConditionAttachmentEntities
                        .DistinctBy(x => x.CycleConditionsProvidedForm!.CycleConditionId)
                        .Count();
                    
                    if (TotalAttachmentsCount != TotalCycleConditionsThatNeedAttachment)
                    {
                        CycleCondition? CycleConditionEntityWithNoAttachments = CycleConditionEntities
                            .FirstOrDefault(x => x.NeedAttachment &&
                                CycleConditionAttachmentEntities.Select(y => y.CycleConditionsProvidedForm!.CycleConditionId).Contains(x.Id));

                        if (CycleConditionEntityWithNoAttachments is not null)
                        {
                            ResponseMessage = Request.lang == "en"
                                ? $"You must upload at least on file for this term: {CycleConditionEntityWithNoAttachments.EnglishDescription}"
                                : $"يجب رفع ملف واحد على الأقل للشرط العام: {CycleConditionEntityWithNoAttachments.ArabicDescription}";

                            return new BaseResponse<object>(ResponseMessage, false, 400);
                        }
                    }
                }
                else if (TotalCycleConditionsThatNeedAttachment != 0)
                {
                    CycleCondition? CycleConditionEntityWithNoAttachments = CycleConditionEntities
                        .FirstOrDefault(x => x.NeedAttachment);

                    if (CycleConditionEntityWithNoAttachments is not null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? $"You must upload at least on file for this term: {CycleConditionEntityWithNoAttachments.EnglishDescription}"
                            : $"يجب رفع ملف واحد على الأقل للشرط العام: {CycleConditionEntityWithNoAttachments.ArabicDescription}";

                        return new BaseResponse<object>(ResponseMessage, false, 400);
                    }
                }
            }

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
