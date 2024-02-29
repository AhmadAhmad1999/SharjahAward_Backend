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

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetTermAndConditionById
{
    public class GetTermAndConditionByIdQueryHandler
        : IRequestHandler<GetTermAndConditionByIdQuery, BaseResponse<TermAndConditionDto>>
    {
        private readonly IAsyncRepository<TermAndCondition> _termAndConditionRepository;
        private readonly IMapper _mapper;

        public GetTermAndConditionByIdQueryHandler(IAsyncRepository<TermAndCondition> termAndConditionRepository, IMapper mapper)
        {
            _termAndConditionRepository = termAndConditionRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<TermAndConditionDto>> Handle(GetTermAndConditionByIdQuery request, CancellationToken cancellationToken)
        {
            var term = await _termAndConditionRepository.GetByIdAsync(request.Id);
            string msg;
            if (term == null)
            {
                msg = request.lang == "en"
                    ? "Term and Condition Not Found"
                    : "لا يوجد بيانات";

                return new BaseResponse<TermAndConditionDto>(msg, false, 404);
            }
            var data = _mapper.Map<TermAndConditionDto>(term);
            data.Title = request.lang == "en" ? term.EnglishTitle : term.ArabicTitle;
            data.Description = request.lang == "en" ? term.EnglishDescription : term.ArabicDescription;

            return new BaseResponse<TermAndConditionDto>("", true,200,data);
        }
    }
}
