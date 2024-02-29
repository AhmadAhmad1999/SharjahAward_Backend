using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Commands.DeleteTermAndCondition
{
    public class DeleteTermAndConditionCommandHandler
        : IRequestHandler<DeleteTermAndConditionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<TermAndCondition> _termAndConditionRepository;

        public DeleteTermAndConditionCommandHandler(IAsyncRepository<TermAndCondition> termAndConditionRepository)
        {
            _termAndConditionRepository = termAndConditionRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteTermAndConditionCommand request, CancellationToken cancellationToken)
        {
            var termToDelete = await _termAndConditionRepository.GetByIdAsync(request.Id);
            string msg;
            if(termToDelete == null)
            {
                msg = request.lang == "en"
                    ? "Term and Condition not Found"
                    : "لا تتوفر بيانات";

                return new BaseResponse<object>(msg, false, 404);
            }
            await _termAndConditionRepository.DeleteAsync(termToDelete);
            msg = request.lang == "en"
                ? "Term and Condition has been Delete"
                : "تم الحذف بنجاح";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
