using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.ChangeStep
{
    public class ChangeStepQueryHandler 
        : IRequestHandler<ChangeStepQuery, BaseResponse<object>>
    {
        private IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;

        public ChangeStepQueryHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository)
        {
            _providedFormRepository = providedFormRepository;
        }

        public async Task<BaseResponse<object>> Handle(ChangeStepQuery request, CancellationToken cancellationToken)
        {
            var form = await _providedFormRepository.GetByIdAsync(request.FormId);
            if(form == null)
            {
                return new BaseResponse<object>("", false, 404);
            }
            form.CurrentStep = request.step;
            form.PercentCompletion = (form.CurrentStep - 1 * 100) / form.TotalStep;
            await _providedFormRepository.UpdateAsync(form);
            return new BaseResponse<object>("", true, 200);
        }
    }
}
