﻿using MediatR;
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

            if(form.PercentCompletion == 100)
            {
                return new BaseResponse<object>("", true, 200);
            }
            else
            {
                form.CurrentStep = request.step;

                var PercentFormula = ((form.CurrentStep - 1) * 100) / form.TotalStep;
                form.PercentCompletion = PercentFormula < 0 ? 0 : PercentFormula;
                await _providedFormRepository.UpdateAsync(form);
                return new BaseResponse<object>("", true, 200);
            }

        }
    }
}
