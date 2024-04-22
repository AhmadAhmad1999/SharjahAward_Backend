using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.CycleModel;
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
            var allCycleCondition = await _cycleConditionRepository
                .OrderByDescending(x => x.CreatedAt, request.page, request.pageSize)
                .ToListAsync();

            if (request.CycleId != null)
            {
                if (request.page != 0 && request.pageSize != -1)
                    allCycleCondition = await _cycleConditionRepository
                        .Where(c => c.CycleId == request.CycleId)
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((request.page - 1) * request.pageSize)
                        .Take(request.pageSize)
                        .ToListAsync();

                else
                    allCycleCondition = await _cycleConditionRepository
                        .Where(c => c.CycleId == request.CycleId)
                        .OrderByDescending(x => x.CreatedAt)
                        .ToListAsync();
            }
           
            var data = _mapper.Map<List<CycleConditionListVM>>(allCycleCondition).OrderBy(a => a.CreatedAt).ToList();

            for (int i = 0; i < data.Count; i++)
            {
                data[i].Title = request.lang == "en"
                    ? data[i].EnglishTitle : data[i].ArabicTitle;

                data[i].Description = request.lang == "en"
                    ? data[i].EnglishDescription : data[i].ArabicDescription;
            }
            int count = request.CycleId == null
                ? _cycleConditionRepository.GetCount(c => !c.isDeleted)
                : _cycleConditionRepository.GetCount(c => c.CycleId == request.CycleId);

            Pagination pagination = new Pagination(request.page,request.pageSize,count);
            return new BaseResponse<List<CycleConditionListVM>>("", true, 200, data, pagination);
        }
    }
}
