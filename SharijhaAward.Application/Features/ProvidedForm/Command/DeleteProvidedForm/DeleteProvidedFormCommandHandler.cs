using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Command.DeleteProvidedForm
{
    public class DeleteProvidedFormCommandHandler
        : IRequestHandler<DeleteProvidedFormCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formRepository;

        public DeleteProvidedFormCommandHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formRepository)
        {
            _formRepository = formRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteProvidedFormCommand request, CancellationToken cancellationToken)
        {
            string msg;

            var form = await _formRepository.GetByIdAsync(request.providedFormId);
            
            if(form == null)
            {
                msg = request.lang == "en"
                    ? "Provided Form dose not Exist"
                    : "لا يوجد إستمارة ";
                
                return new BaseResponse<object>(msg,false,404);
            }
            await _formRepository.DeleteAsync(form);
            msg = request.lang == "en"
                   ? "Provided Form has been Deleted"
                   : "تم حذف الإستمارة بنجاح";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
