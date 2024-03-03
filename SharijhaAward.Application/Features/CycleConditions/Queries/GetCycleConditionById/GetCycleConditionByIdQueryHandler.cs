using AutoMapper;
using MediatR;
using Org.BouncyCastle.Crypto.Engines;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionById
{
    public class GetCycleConditionByIdQueryHandler
        : IRequestHandler<GetCycleConditionByIdQuery, BaseResponse<CycleConditionDto>>
    {
        private readonly IAsyncRepository<CycleCondition> _cycleConditionRepository;
        private readonly IMapper _mapper;

        public GetCycleConditionByIdQueryHandler(IAsyncRepository<CycleCondition> cycleConditionRepository, IMapper mapper)
        {
            _cycleConditionRepository = cycleConditionRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<CycleConditionDto>> Handle(GetCycleConditionByIdQuery request, CancellationToken cancellationToken)
        {
            var cycleCondition = await _cycleConditionRepository.GetByIdAsync(request.Id); 
            
            if (cycleCondition == null)
            {
                var msg = request.lang == "en"
                    ? "Cycle Condition Not Found"
                    : "شرط الدورة غير موجود";

                return new BaseResponse<CycleConditionDto>("", false, 404);
            }
            var data = _mapper.Map<CycleConditionDto>(cycleCondition);

            data.Title = request.lang == "en" ? cycleCondition.EnglishTitle : cycleCondition.ArabicTitle;
        
            return new BaseResponse<CycleConditionDto>("", true, 200, data);
        }
    }
}
