using AutoMapper;
using MediatR;
using Microsoft.VisualBasic;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AwardStatisticModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardStatistics.Commands.UpdateAwardStatistic
{
    public class UpdateAwardStatisticCommandHandler
        : IRequestHandler<UpdateAwardStatisticCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<AwardStatistic> _awardStatisticRepository;
        private readonly IMapper _mapper;

        public UpdateAwardStatisticCommandHandler(IAsyncRepository<AwardStatistic> awardStatisticRepository, IMapper mapper)
        {
            _awardStatisticRepository = awardStatisticRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateAwardStatisticCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                       ? "Award Statistic has been Updated"
                       : "تم تعديل الإحصائية";

            var Statistic = await _awardStatisticRepository.GetByIdAsync(request.Id);

            if (Statistic == null)
            {
                msg = request.lang == "en"
                ? "Award Statistic Not Found"
                : "الإحصائية غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            _mapper.Map(request, Statistic, typeof(UpdateAwardStatisticCommand), typeof(AwardStatistic));

            await _awardStatisticRepository.UpdateAsync(Statistic);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
