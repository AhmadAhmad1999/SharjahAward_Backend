using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AwardStatisticModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardStatistics.Queries.GetAllAwardStatistics
{
    public class GetAllAwardStatisticsQueryHandler
        : IRequestHandler<GetAllAwardStatisticsQuery, BaseResponse<List<AwardStatisticListVM>>>
    {
        private readonly IAsyncRepository<AwardStatistic> _awardStatisticRepository;
        private readonly IMapper _mapper;

        public GetAllAwardStatisticsQueryHandler(IAsyncRepository<AwardStatistic> awardStatisticRepository, IMapper mapper)
        {
            _awardStatisticRepository = awardStatisticRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<AwardStatisticListVM>>> Handle(GetAllAwardStatisticsQuery request, CancellationToken cancellationToken)
        {
            var AllStatistics = await _awardStatisticRepository.GetWhereThenPagedReponseAsync(a => a.CycleId == request.CycleId, request.page, request.pageSize);

            var data = _mapper.Map<List<AwardStatisticListVM>>(AllStatistics);

            foreach(var item in data)
            {
                item.Title = request.lang == "en" ? item.EnglishTitle : item.ArabicTitle;
            }

            int count = _awardStatisticRepository.GetCount(a => a.CycleId == request.CycleId);

            Pagination pagination = new Pagination(request.page, request.pageSize, count);

            return new BaseResponse<List<AwardStatisticListVM>>("", true, 200, data, pagination);
        }
    }
}
