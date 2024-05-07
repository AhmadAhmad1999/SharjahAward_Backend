using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AwardStatisticModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardStatistics.Commands.CreateAwardStatistic
{
    public class CreateAwardStatisticCommandHandler
        : IRequestHandler<CreateAwardStatisticCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IAsyncRepository<AwardStatistic> _awardStatisticRepository;
        private readonly IMapper _mapper;

        public CreateAwardStatisticCommandHandler(IAsyncRepository<Cycle> cycleRepository, IAsyncRepository<AwardStatistic> awardStatisticRepository, IMapper mapper)
        {
            _cycleRepository = cycleRepository;
            _awardStatisticRepository = awardStatisticRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateAwardStatisticCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Award Statistic has been Added"
                : "تم إضافة الإحصائية";
            
            var cycle = await _cycleRepository.GetByIdAsync(request.CycleId);
           
            if(cycle == null)
            {
                msg = request.lang == "en"
                ? "Cycle Not Found"
                : "الدورة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            var Statistic = _mapper.Map<AwardStatistic>(request);

            await _awardStatisticRepository.AddAsync(Statistic);

            return new BaseResponse<object>(msg, true, 200);

        }
    }
}
