using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.AgreeOnCycleCondition
{
    public class AgreeOnCycleConditionQueryHandler
        : IRequestHandler<AgreeOnCycleConditionQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CycleCondition> _termRepository;
        private readonly IAsyncRepository<CycleConditionsProvidedForm> _conditionsProvidedFormsRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;

        public AgreeOnCycleConditionQueryHandler(IAsyncRepository<CycleCondition> termRepository, IAsyncRepository<CycleConditionsProvidedForm> conditionsProvidedFormsRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository, IUserRepository userRepository, IJwtProvider jwtProvider)
        {
            _termRepository = termRepository;
            _conditionsProvidedFormsRepository = conditionsProvidedFormsRepository;
            _providedFormRepository = providedFormRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
        }

        public async Task<BaseResponse<object>> Handle(AgreeOnCycleConditionQuery request, CancellationToken cancellationToken)
        {
            var ConditionForm = _conditionsProvidedFormsRepository.Where(c => c.CycleConditionId == request.TermId && c.ProvidedFormId == request.formId).FirstOrDefault();
            if (ConditionForm != null)
            {
                ConditionForm.IsAgree = request.IsAgree;
                await _conditionsProvidedFormsRepository.UpdateAsync(ConditionForm);
            }
            else
            {
                var UserID = _jwtProvider.GetUserIdFromToken(request.token);
                var user = await _userRepository.GetByIdAsync(new Guid(UserID));
                if (user == null)
                {
                    return new BaseResponse<object>("", false, 404);
                }
                var form = _providedFormRepository.Where(f => f.Id == request.formId).FirstOrDefault();
                if (form == null)
                {
                    return new BaseResponse<object>("", false, 404);
                }
                var term = await _termRepository.GetByIdAsync(request.TermId);
                if (term == null)
                {
                    return new BaseResponse<object>("", false, 404);
                }
                CycleConditionsProvidedForm conditionsProvided = new CycleConditionsProvidedForm();
                conditionsProvided.IsAgree = request.IsAgree;
                conditionsProvided.CycleConditionId = term.Id;
                conditionsProvided.ProvidedFormId = form!.Id;

                await _conditionsProvidedFormsRepository.AddAsync(conditionsProvided);
            }

            return new BaseResponse<object>("", true, 200);
        }
    }
}
