using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AwardStatisticModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardStatistics.Commands.DeleteAwardStatistic
{
    public class DeleteAwardStatisticCommandHandler
        : IRequestHandler<DeleteAwardStatisticCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<AwardStatistic> _awardStatisticRepository;
        public DeleteAwardStatisticCommandHandler(IAsyncRepository<AwardStatistic> awardStatisticRepository)
        {
            _awardStatisticRepository = awardStatisticRepository;
        }
        public async Task<BaseResponse<object>> Handle(DeleteAwardStatisticCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Award Statistic has been Deleted"
                : "تم حذف الإحصائية";

            var Statistic = await _awardStatisticRepository.GetByIdAsync(request.Id);

            if(Statistic == null)
            {
                msg = request.lang == "en"
                ? "Award Statistic Not Found"
                : "الإحصائية غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _awardStatisticRepository.DeleteAsync(Statistic);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
