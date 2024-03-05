using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
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
        private readonly IMapper _mapper;

        public AgreeOnTermsAndConditionQueryHandler(IAsyncRepository<TermAndCondition> termRepository, IMapper mapper)
        {
            _termRepository = termRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(AgreeOnTermsAndConditionQuery request, CancellationToken cancellationToken)
        {
            var term = await _termRepository.GetByIdAsync(request.TermId);
            if(term == null)
            {
                return new BaseResponse<object>("", false, 404);
            }
            term.IsAgree = request.IsAgree;
            await _termRepository.UpdateAsync(term);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
