using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.CheckAllCycleConditions
{
    public class CheckAllCycleConditionsQueryHandler
        : IRequestHandler<CheckAllCycleConditionsQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CycleConditionAttachment> _conditionAttachmentRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IAsyncRepository<CycleCondition> _termRepository;
        private readonly IAsyncRepository<CycleConditionsProvidedForm> _conditionsProvidedFormsRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;

        public CheckAllCycleConditionsQueryHandler(IAsyncRepository<CycleConditionAttachment> conditionAttachmentRepository, IAsyncRepository<Cycle> cycleRepository, IAsyncRepository<CycleCondition> termRepository, IAsyncRepository<CycleConditionsProvidedForm> conditionsProvidedFormsRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository)
        {
            _conditionAttachmentRepository = conditionAttachmentRepository;
            _cycleRepository = cycleRepository;
            _termRepository = termRepository;
            _conditionsProvidedFormsRepository = conditionsProvidedFormsRepository;
            _providedFormRepository = providedFormRepository;
        }

        public async Task<BaseResponse<object>> Handle(CheckAllCycleConditionsQuery request, CancellationToken cancellationToken)
        {
            string msg;
            var cycle = _cycleRepository.Where(c => c.Status == Domain.Constants.Common.Status.Active).FirstOrDefault();
            if(cycle == null)
            {
                msg = request.lang == "en"
                            ? "There is no Active Cycle"
                            : "لا يوجد دورات فعالة";

                return new BaseResponse<object>(msg, false, 404);
            }
            if (cycle.Status == Domain.Constants.Common.Status.Close)
            {
                msg = request.lang == "en"
                    ? "The Status of Cycle is Close"
                    : "حالة الدورة مغلقة";

                return new BaseResponse<object>(msg, false, 400);
            }

            var form = await _providedFormRepository.FirstOrDefaultAsync(p => p.Id == request.formId);

            var terms = await _termRepository
                .Where(t => t.CycleId == cycle.Id)
                .ToListAsync();

            if (terms.Any())
            {
                List<CycleConditionAttachment> conditionsProvideds = await _conditionAttachmentRepository
                    .Where(x => terms.Select(y => y.Id).Contains(x.CycleConditionsProvidedForm!.CycleConditionId) &&
                        x.CycleConditionsProvidedForm!.ProvidedFormId == form!.Id)
                    .ToListAsync();

                for (int i = 0; i < terms.Count(); i++)
                {
                    //Check on Terms that need Attachments
                    if (terms[i].NeedAttachment) 
                    {
                        msg = request.lang == "en"
                            ? "You can't upload more files"
                            : "لا يمكنك رفع المزيد من الملفات";

                        List<CycleConditionAttachment> conditionsProvidedsForThisTerm = conditionsProvideds
                            .Where(x => x.CycleConditionsProvidedForm!.CycleConditionId == terms[i].Id)
                            .ToList();

                        if (terms[i].RequiredAttachmentNumber < conditionsProvidedsForThisTerm.Count() && 
                            terms[i].RequiredAttachmentNumber != 0)
                        {
                            return new BaseResponse<object>(msg, false, 400);
                        }

                        if (!conditionsProvidedsForThisTerm.Any())
                        {
                            msg = request.lang == "en"
                                ? $"You must upload at least on file for this term: {terms[i].EnglishTitle}"
                                : $"يجب رفع ملف واحد على الأقل للشرط العام: {terms[i].ArabicTitle}";

                            return new BaseResponse<object>(msg, false, 400);
                        }
                    }

                    //Check on Terms that don't need Attachments
                    else
                    {
                        if (!conditionsProvideds[i].CycleConditionsProvidedForm!.IsAgree && !terms[i].NeedAttachment)
                        {
                            msg = request.lang == "en"
                                ? "Pleas Agree on All Terms and Conditions"
                                : "الرجاء الموافقة على جميع الشروط و الأحكام";
                            return new BaseResponse<object>(msg, false, 400);

                        }
                    }
                }
            }
            return new BaseResponse<object>("", true, 200);
        }
    }
}
