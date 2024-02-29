using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.GetAllCycleConditions
{
    public class GetAllCycleConditionsQueryHandler
        : IRequestHandler<GetAllCycleConditionsQuery, BaseResponse<List<CycleConditionListVM>>>
    {
        private readonly IAsyncRepository<CycleCondition> _cycleConditionRepository;
        private readonly IMapper _mapper;

        public GetAllCycleConditionsQueryHandler(IAsyncRepository<CycleCondition> cycleConditionRepository, IMapper mapper)
        {
            _cycleConditionRepository = cycleConditionRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<CycleConditionListVM>>> Handle(GetAllCycleConditionsQuery request, CancellationToken cancellationToken)
        {
            var allCycleCondition = await _cycleConditionRepository.GetPagedReponseAsync(request.page, request.pageSize);
            if(allCycleCondition.Count == 0)
            {
                var data = _mapper.Map<List<CycleConditionListVM>>(allCycleCondition);

                return new BaseResponse<List<CycleConditionListVM>>("", true, 200, data);
            }
            List<CycleConditionListVM> cycleConditionsList = new List<CycleConditionListVM>();
            for (int i = 0; i < allCycleCondition.Count; i++)
            {
                CycleConditionListVM cycleCondition =new CycleConditionListVM()
                {
                    Id = allCycleCondition[i].Id,
                    CreatedAt = allCycleCondition[i].CreatedAt,
                    Title = request.lang == "en" 
                    ? allCycleCondition[i].EnglishTitle
                    : allCycleCondition[i].ArabicTitle
                };
                cycleConditionsList.Add(cycleCondition);
            }
            int count = _cycleConditionRepository.ListAllAsync().Result.Count();

            return new BaseResponse<List<CycleConditionListVM>>("", true, 200, cycleConditionsList,count);
        }
    }
}
