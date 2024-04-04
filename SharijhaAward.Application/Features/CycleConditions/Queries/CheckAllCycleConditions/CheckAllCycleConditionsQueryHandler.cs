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
            var cycle = _cycleRepository.Where(c => c.Status == 0).FirstOrDefault();
            if(cycle == null)
            {
                msg = request.lang == "en"
                            ? "There is no Active Cycle"
                            : "لا يوجد دورات فعالة";

                return new BaseResponse<object>(msg, false, 404);
            }

            var form = await _providedFormRepository.FirstOrDefaultAsync(p => p.Id == request.formId);

            var terms = await _termRepository.WhereThenInclude(t => t.CycleId == cycle.Id, t => t.ConditionAttachments).ToListAsync();

            List<CycleConditionsProvidedForm> conditionsProvideds = new List<CycleConditionsProvidedForm>();

            for (int i = 0; i < terms.Count(); i++)
            {
                var conditionsProvidedsobject =
                 _conditionsProvidedFormsRepository.WhereThenInclude(
                     c => c.ProvidedFormId == form!.Id && c.CycleConditionId == terms[i].Id,
                     c => c.Attachments).FirstOrDefault();

                if (conditionsProvidedsobject != null)
                    conditionsProvideds.Add(conditionsProvidedsobject!);
            }

           
            if (terms.Count() != 0)
            {
                for (int i = 0; i < terms.Count(); i++)
                {
                    //Check on Terms that need Attachments
                    if (terms[i].RequiredAttachmentNumber != conditionsProvideds[i].Attachments.Count()
                        && terms[i].RequiredAttachmentNumber != 0)
                    {
                        msg = request.lang == "en"
                            ? "Please Complete Uploading The File "
                            : "الرجاء إكمال رفع الملفات";

                        return new BaseResponse<object>(msg, false, 400);

                    }
                    //Check on Terms that don't need Attachments
                    else if (!conditionsProvideds[i].IsAgree && !terms[i].NeedAttachment)
                    {
                        msg = request.lang == "en"
                            ? "Pleas Agree on All Terms and Conditions"
                            : "الرجاء الموافقة على جميع الشروط و الأحكام";
                        return new BaseResponse<object>(msg, false, 400);

                    }
                    else if (
                        terms[i].RequiredAttachmentNumber == 0 &&
                        conditionsProvideds[i].Attachments.Count() < 1 &&
                        terms[i].NeedAttachment
                        )
                    {
                        msg = request.lang == "en"
                             ? "Please Complete Uploading The File "
                             : "الرجاء إكمال رفع الملفات";

                        return new BaseResponse<object>(msg, false, 400);
                    }
                }
            }
            return new BaseResponse<object>("", true, 200);
        }
    }
}
