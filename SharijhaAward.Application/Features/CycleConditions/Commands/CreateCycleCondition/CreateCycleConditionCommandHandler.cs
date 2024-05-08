using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Commands.CreateCycleCondition
{
    public class CreateCycleConditionCommandHandler
        : IRequestHandler<CreateCycleConditionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CycleCondition> _cycleConditionRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IMapper _mapper;

        public CreateCycleConditionCommandHandler(
            IAsyncRepository<CycleCondition> cycleConditionRepository,
            IAsyncRepository<Cycle> cycleRepository,
            IMapper mapper)
        {
            _cycleConditionRepository = cycleConditionRepository;
            _cycleRepository = cycleRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateCycleConditionCommand request, CancellationToken cancellationToken)
        {
            var cycleCondition = _mapper.Map<CycleCondition>(request);
            var cycle = await _cycleRepository.GetByIdAsync(request.CycleId);
            string msg;
            if(cycle == null)
            {
                msg = request.lang == "en"
                    ? "The Cycle is not Found"
                    : "الدورة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }
            if (cycle.Status == Domain.Constants.Common.Status.Close)
            {
                msg = request.lang == "en"
                    ? "The Status of Cycle is Close"
                    : "حالة الدورة مغلقة";

                return new BaseResponse<object>(msg, false, 400);
            }
            
            await _cycleConditionRepository.AddAsync(cycleCondition);

            msg = request.lang == "en"
                ? "The Cycle Condition has been Created"
                : "تم إضافة شرط الدورة بنجاح";

            return new BaseResponse<object>(msg, true, 200);

        }
    }
}
