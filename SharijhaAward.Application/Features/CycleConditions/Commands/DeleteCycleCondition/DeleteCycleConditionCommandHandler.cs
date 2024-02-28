using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Commands.DeleteCycleCondition
{
    public class DeleteCycleConditionCommandHandler
        : IRequestHandler<DeleteCycleConditionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CycleCondition> _cycleConditionRepository;

        public DeleteCycleConditionCommandHandler(IAsyncRepository<CycleCondition> cycleConditionRepository)
        {
            _cycleConditionRepository = cycleConditionRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteCycleConditionCommand request, CancellationToken cancellationToken)
        {
            var CycleConditionToDelete = await _cycleConditionRepository.GetByIdAsync(request.Id);
            string msg;
            if (CycleConditionToDelete == null)
            {
                msg = request.lang == "en"
                    ? "The Condition is not Found"
                    : "شرط الدورة غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }
            await _cycleConditionRepository.DeleteAsync(CycleConditionToDelete);
            msg = request.lang == "en"
              ? "The Condition has been Deleted"
              : "تم حذف شرط الدورة بنجاح";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
