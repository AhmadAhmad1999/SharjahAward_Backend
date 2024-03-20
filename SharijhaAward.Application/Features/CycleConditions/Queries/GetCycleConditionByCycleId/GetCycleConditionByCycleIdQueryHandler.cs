using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionByCycleId
{
    public class GetCycleConditionByCycleIdQueryHandler
        : IRequestHandler<GetCycleConditionByCycleIdQuery, BaseResponse<List<CycleConditionDto>>>
    {
        private readonly IAsyncRepository<CycleCondition> _cycleConditionRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IMapper _mapper;

        public GetCycleConditionByCycleIdQueryHandler(IAsyncRepository<CycleCondition> cycleConditionRepository, IAsyncRepository<Cycle> cycleRepository, IMapper mapper)
        {
            _cycleConditionRepository = cycleConditionRepository;
            _cycleRepository = cycleRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<CycleConditionDto>>> Handle(GetCycleConditionByCycleIdQuery request, CancellationToken cancellationToken)
        {
            var Cycle = await _cycleRepository.GetByIdAsync(request.CycleId);
            if(Cycle == null)
            {
                return new BaseResponse<List<CycleConditionDto>>("", false, 404);
            }
            var Conditions = _cycleConditionRepository.Where(c => c.CycleId == request.CycleId).ToList();
            
            var data = _mapper.Map<List<CycleConditionDto>>(Conditions);

            for(int i = 0; i < data.Count(); i++)
            {
                data[i].Title = request.lang == "en"
                    ? data[i].EnglishTitle
                    : data[i].ArabicTitle;
            }

            return new BaseResponse<List<CycleConditionDto>>("",true,200,data);
        }
    }
}
