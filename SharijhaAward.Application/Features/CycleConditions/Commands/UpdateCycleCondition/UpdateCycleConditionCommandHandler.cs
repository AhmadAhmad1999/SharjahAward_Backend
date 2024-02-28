using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleClassModel;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Commands.UpdateCycleCondition
{
    public class UpdateCycleConditionCommandHandler
        : IRequestHandler<UpdateCycleConditionCommand, BaseResponse<object>>
    {
        private IAsyncRepository<CycleCondition> _cycleConditionRepository;
        private IMapper _mapper;

        public UpdateCycleConditionCommandHandler(IAsyncRepository<CycleCondition> cycleConditionRepository, IMapper mapper)
        {
            _cycleConditionRepository = cycleConditionRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateCycleConditionCommand request, CancellationToken cancellationToken)
        {
            var cycleConditionToUpadate = await _cycleConditionRepository.GetByIdAsync(request.Id);
            string msg;
            if(cycleConditionToUpadate == null)
            {
                msg = request.lang == "en"
                    ? "The Condition is not exsist"
                    : "شرط الدورة غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }
            _mapper.Map(request, cycleConditionToUpadate, typeof(UpdateCycleConditionCommand), typeof(CycleCondition));

            await _cycleConditionRepository.UpdateAsync(cycleConditionToUpadate);

            msg = request.lang == "en"
                ? "Cycle Condition has been Updated"
                : "تم تعديل شرط الدورة بنجاح";

            return new BaseResponse<object>(msg, false, 404);

        }
    }
}
