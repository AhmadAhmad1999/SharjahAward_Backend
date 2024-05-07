using MediatR;
using SharijhaAward.Application.Responses;
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

        public Task<BaseResponse<object>> Handle(UpdateAwardStatisticCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
