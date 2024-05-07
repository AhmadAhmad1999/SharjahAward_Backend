using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AwardPublicationsModel;
using SharijhaAward.Domain.Entities.AwardStatisticModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardStatistics.Queries.GetAwardStatisticById
{
    public class GetAwardStatisticByIdQueryHandler
        : IRequestHandler<GetAwardStatisticByIdQuery, BaseResponse<AwardStatisticDto>>
    {
        private readonly IAsyncRepository<AwardStatistic> _awardStatisticRepository;
        private readonly IMapper _mapper;

        public GetAwardStatisticByIdQueryHandler(IAsyncRepository<AwardStatistic> awardStatisticRepository, IMapper mapper)
        {
            _awardStatisticRepository = awardStatisticRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<AwardStatisticDto>> Handle(GetAwardStatisticByIdQuery request, CancellationToken cancellationToken)
        {
            var Statistic = await _awardStatisticRepository.GetByIdAsync(request.Id);

            if(Statistic == null)
            {
              string msg = request.lang == "en"
                            ? "Award Statistic Not Found"
                            : "الإحصائية غير موجودة";

                return new BaseResponse<AwardStatisticDto>(msg, false, 404);
            }

            var data = _mapper.Map<AwardStatisticDto>(Statistic);

            return new BaseResponse<AwardStatisticDto>("", true, 200, data);
        }
    }
}
