using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.AgreeOnTermsAndCondition
{
    public class AgreeOnTermsAndConditionQueryHandler
        : IRequestHandler<AgreeOnTermsAndConditionQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<TermAndCondition> _termRepository;
        private readonly IAsyncRepository<ConditionsProvidedForms> _conditionsProvidedFormsRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public AgreeOnTermsAndConditionQueryHandler(
            IAsyncRepository<ConditionsProvidedForms> conditionsProvidedFormsRepository,
            IAsyncRepository<TermAndCondition> termRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository,
            IUserRepository userRepository,
            IJwtProvider jwtProvider,
            IMapper mapper)
        {
            _termRepository = termRepository;
            _conditionsProvidedFormsRepository = conditionsProvidedFormsRepository;
            _providedFormRepository = providedFormRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(AgreeOnTermsAndConditionQuery request, CancellationToken cancellationToken)
        {
            var ConditionForm = _conditionsProvidedFormsRepository.Where(c => c.TermAndConditionId == request.TermId).FirstOrDefault();
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
                var form = _providedFormRepository.Where(f => f.userId == user.Id).FirstOrDefault();
                if (form == null)
                {
                    return new BaseResponse<object>("", false, 404);
                }
                var term = await _termRepository.GetByIdAsync(request.TermId);
                if (term == null)
                {
                    return new BaseResponse<object>("", false, 404);
                }
                ConditionsProvidedForms conditionsProvided = new ConditionsProvidedForms();
                conditionsProvided.IsAgree = request.IsAgree;
                conditionsProvided.TermAndConditionId = term.Id;
                conditionsProvided.ProvidedFormId = form!.Id;

                await _conditionsProvidedFormsRepository.AddAsync(conditionsProvided);
            }

            return new BaseResponse<object>("", true, 200);
            
        }
    }
}
